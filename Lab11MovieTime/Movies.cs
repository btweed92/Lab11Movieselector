using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11MovieTime
{
    public class Movies
    {
        #region fields
        private string title;
        private string category;
        #endregion

        #region properties
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        #endregion

        #region constructor
        public Movies()
        {

        }
        public Movies(string _title, string _category)
        {
            title = _title;
            category = _category;
        }
        #endregion

        #region methods
        public static void DisplayMenu()
        {
            Console.WriteLine("       Please choose a category:    ");
            Console.WriteLine("              1. Horror             ");
            Console.WriteLine("              2. SciFi              ");
            Console.WriteLine("              3. Action             ");
            Console.WriteLine("              4. Animated           ");
            Console.WriteLine("              5. Quit               ");
            Console.WriteLine("     ============================== ");
            Console.WriteLine();
        }

        #endregion

    }
}
