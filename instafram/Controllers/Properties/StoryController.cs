using Microsoft.AspNetCore.Mvc;
using instafram.BLL;
using instafram.DAL;
using instafram.Models;

namespace instafram.Controllers
{
    public class StoryController : Controller
    {
        private readonly StoryService _storyService;
        private readonly StoryLikeService _storyLikeService;
        public StoryController(StoryService storyService, StoryLikeService storyLikeService)
        {
            _storyService = storyService;
            _storyLikeService = storyLikeService;
        }
        public IActionResult Index()
        {
            List<Story> story = _storyService.GetStories();
            return View(story);
        }

        public IActionResult StoryLikePost(int Id)
        {
            Story story = _storyService.GetStory(Id);

            if (story == null)
            {
                return NotFound();
            }

            Storylike like = new Storylike()
            {
                StoryId = Id,
                UserId = 1,
                Timestamp = DateTime.Now,
            };

            story.Views++;
            story.LikeStory++;
            _storyService.UpdateStory(story);
            _storyLikeService.CreateStoryLike(like);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult NewStory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewStory(Story story)
        {
            if (ModelState.IsValid)
            {
                _storyService.CreateStory(story);

                return Redirect("/Story/Index");
            }

            return View(story);
        }
    }
}