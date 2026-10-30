using b3_Nguyen_thi_phuong_anh.Models;

namespace b3_Nguyen_thi_phuong_anh.Data
{
    public class seedData
    {
        //Gia lap du lieu ban dau cho Database
        public static List<Category> categories = new List<Category>
        {
            new Category(){Id=1,Name="Category 1",Description="Description 1"},
            new Category(){Id=2,Name="Category 2",Description="Description 2"},
            new Category(){ Id=3, Name = "Category 3",Description= "Description  3"},
        };
    }
}
