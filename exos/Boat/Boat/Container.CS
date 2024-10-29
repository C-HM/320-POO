using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    class Container : IContainer
    {
        public Container(int id, float weight, bool isRefrigerated, List<string> merchandise, string color)
        {
            this.Id = id;
            this.Weight = weight;
            this.IsRefrigerated = isRefrigerated;
            this.Merchandise = merchandise;
            this.Color = color;
        }

        public int Id { get; set; }
        public float Weight { get; set; }
        public bool IsRefrigerated { get; set; }
        public List<string> Merchandise { get; set; }
        public string Color { get; set; }

        public void ViewContent()
        {
            Console.WriteLine(Merchandise);
        }
        public void AddMerchandise(string item)
        {
            Merchandise.Add(item);
        }
    }

}