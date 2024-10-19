
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Data;
using ToDo.Models;

namespace ToDo.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ToDoController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // Displays the list of to-do items
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User); // Get the ID of the logged-in user

            // Debugging log
            Console.WriteLine($"Logged in UserId: {userId}");

            var tasks = await _context.ToDos
                .Where(t => t.UserId == userId) // Filter tasks by the user ID
                .ToListAsync();

            // Debugging log
            Console.WriteLine($"Tasks retrieved: {tasks.Count}");

            return View(tasks); // Pass the user-specific tasks to the view
        }

        #region Create

        // Displays the form to create a new to-do item
        public IActionResult Create()
        {
            // Pass any necessary data for dropdowns (e.g., Categories or Priority)
            ViewBag.PriorityList = GetPriorityList();
            return View();
        }

        // Handles the HTTP POST request to create a new to-do item
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ToDo.Models.ToDo todo)
        {
            if (ModelState.IsValid)
            {
                // Set the UserId to the current logged-in user's ID
                todo.UserId = _userManager.GetUserId(User);

                // Debugging log
                Console.WriteLine($"Creating task for UserId: {todo.UserId}");

                // Add the task to the database
                _context.ToDos.Add(todo);
                await _context.SaveChangesAsync(); // Save asynchronously

                return RedirectToAction("Index");
            }

            ViewBag.PriorityList = GetPriorityList(); // Re-populate Priority dropdown in case of validation failure
            return View(todo);
        }

        #endregion

        #region Details

        // Displays details of a specific to-do item
        public IActionResult Details(int id)
        {
            var toDo = _context.ToDos.FirstOrDefault(x => x.Id == id);
            if (toDo == null)
            {
                return NotFound();
            }

            return View(toDo);
        }

        #endregion

        #region Edit

        // Displays the form to edit a specific to-do item
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var toDo = _context.ToDos.FirstOrDefault(x => x.Id == id);
            if (toDo == null)
            {
                return NotFound();
            }

            ViewBag.PriorityList = GetPriorityList(); // Pass Priority options
            return View(toDo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, ToDo.Models.ToDo toDo)
        {
            if (id != toDo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // Fetch the existing entity from the database
                var existingToDo = await _context.ToDos.FirstOrDefaultAsync(x => x.Id == id);

                if (existingToDo == null)
                {
                    return NotFound(); // Ensure the item exists
                }

                // Update properties of the existing entity
                existingToDo.Title = toDo.Title;
                existingToDo.Details = toDo.Details;
                existingToDo.Date = toDo.Date;
                existingToDo.IsDone = toDo.IsDone;
                existingToDo.Priority = toDo.Priority;
                existingToDo.Category = toDo.Category;
                existingToDo.ReminderDate = toDo.ReminderDate;
                existingToDo.AttachmentPath = toDo.AttachmentPath;
                existingToDo.UserId = toDo.UserId;
                existingToDo.IsRecurring = toDo.IsRecurring;
                existingToDo.RecurringInterval = toDo.RecurringInterval;
                existingToDo.Tags = toDo.Tags;
                existingToDo.CompletionPercentage = toDo.CompletionPercentage;
                existingToDo.EstimatedDuration = toDo.EstimatedDuration;
                existingToDo.Color = toDo.Color;
                existingToDo.UserId = _userManager.GetUserId(User);
                // Save changes asynchronously
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PriorityList = GetPriorityList(); // Re-populate Priority dropdown in case of validation failure
            return View(toDo);
        }
        #endregion

        #region Delete

        // Displays a confirmation page for deleting a specific to-do item
        public IActionResult Delete(int id)
        {
            var toDo = _context.ToDos.FirstOrDefault(x => x.Id == id);
            if (toDo == null)
            {
                return NotFound();
            }

            return View(toDo);
        }

        // Handles the HTTP POST request to delete a specific to-do item
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var toDo = await _context.ToDos.FirstOrDefaultAsync(x => x.Id == id);
            if (toDo != null)
            {
                _context.ToDos.Remove(toDo);
                await _context.SaveChangesAsync(); // Save asynchronously
            }

            return RedirectToAction("Index");
        }

        #endregion

        // Helper method to get priority levels
        private SelectList GetPriorityList()
        {
            var priorityLevels = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Low" },
                new SelectListItem { Value = "2", Text = "Medium" },
                new SelectListItem { Value = "3", Text = "High" }
            };

            return new SelectList(priorityLevels, "Value", "Text");
        }
    }
}
