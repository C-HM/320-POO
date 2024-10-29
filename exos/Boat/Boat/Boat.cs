using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    class Boat : IBoat
    {
        public Boat(string name, float maxCargoWeight, int maxSpeed)
        {
            this.Name = name;
            this.MaxCargoWeight = maxCargoWeight;
            this.MaxSpeed = maxSpeed;
        }
        public string Name { get; private set; }
        public float MaxCargoWeight { get; private set; }
        public int MaxSpeed { get; private set; }
        
        bool help = true;

        public void Start()
        {

        }
        public bool LoadContainer(IContainer container)
        {
            return help;
        }
        public bool UnloadContainer(IContainer container)
        {
            return help;
        }
    }
}