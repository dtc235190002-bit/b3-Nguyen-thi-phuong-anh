using b3_Nguyen_thi_phuong_anh.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace b3_Nguyen_thi_phuong_anh.Controllers
{
    public class categoryController1 : Controller
    {
        // GET: categoryController1 
        public ActionResult Index()
        {
            var _category = seedData.categories;
            return View(_category);
        }                           

        // GET: categoryController1/Details/5
        public ActionResult Details(int id)
        {
            //lay ra category co id truyen vao tu SeedData
            var category = seedData.categories.FirstOrDefault(c => c.Id == id);
            //neu category=null thi tra ve trang loi
            if (category ==null)
            {
                return NotFound();
            }
            //neu category khac null thi tra ve view va truyen category vao view
            return View(category);
        }

        // GET: categoryController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: categoryController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create([FromForm] Models.Category category)
        {
            if(ModelState.IsValid)
            {
                //Lay max id trong danh sach SeedData. categories
                int maxId = seedData.categories.Max(c => c.Id);
                //set id cho category
                category.Id = maxId + 1;
                //them category vao danh sach SeedData.categoories
                seedData.categories.Add(category);
                return RedirectToAction(nameof(Index));
            }

            return View();
 
            }
           //GET: CategoryController/Edit/5
           public ActionResult Edit([FromRoute] int id)
           {
            var category = seedData.categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
                return View(category);
            }
        

        // GET: categoryController1/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: categoryController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: categoryController1/Delete/5

        public ActionResult Delete(int id)
        {
            var category = seedData.categories.FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }


        // POST: categoryController1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed([FromRoute] int id )
        {
            var existingCategory = seedData.categories.FirstOrDefault(C => C.Id == id);
            if (existingCategory == null)
            {
                return NotFound();
                
            }
            seedData.categories.Remove(existingCategory);
            return RedirectToAction(nameof(Index));
            
           
            }
        }
    }

