using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT
{
    public class AddNewRecipe : ObservableObject, IDataErrorInfo
    {
        public string Error { get { return null;  } }
        
        private string _recipe, _description;

       

        public string Recipe
        {
            get { return _recipe;  }
            set
            {
                OnPropertyChanged(ref _recipe, value);
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                OnPropertyChanged(ref _description, value);
            }
        }
        public string this[string recipe]
        {
            get
            {
                string result = null;

                switch (recipe)
                {
                    case "Recipe":
                        if (string.IsNullOrWhiteSpace(Recipe))
                        {
                            result = "Field cannot be empty";
                        }
                        break;

                    case "Description":
                        if (string.IsNullOrWhiteSpace(Description))
                        {
                            result = "Field cannot be empty";
                        }
                        break;
                }

             

                return result;
            }
        }

        
    }
}
