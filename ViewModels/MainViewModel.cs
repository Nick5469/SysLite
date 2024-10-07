using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;
using Windows.UI.Input;

namespace App3
{
    internal class MainViewModel
    {
        public class ClassImage(string ImageName, string ImageFlag, string ImageVer)
        {
            public string ImageName { get; set; } = ImageName;
            public string ImageFlag { get; set; } = ImageFlag;
            public string ImageVer { get; set; } = ImageVer;
        }

        internal ObservableCollection<ClassImage> ClassImages { get; set; } =
        [
            new ClassImage("Windows 11","Pro","21996"),
            new ClassImage("Windows 10","Professional","22004"),
        ];

        internal void AddOne()
        {
            var ran = new Random();
            ClassImages.Add(new(ran.Next().ToString(), ran.Next().ToString(), ran.Next().ToString()));
        }

        internal void RemoveOne()
        {
            ClassImages.RemoveAt(ClassImages.Count - 1);
        }
    }
}
