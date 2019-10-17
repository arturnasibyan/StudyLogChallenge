using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyLogCodingTest
{
    public class Animal
    {
        private String _nameTag;
        //in ounces
        private float _weight;
        private String _color;
        private String _group;
        private String _gender;

        public Animal(String nameTag, float weight)
        {
            _nameTag = nameTag;
            _weight = weight;
        }

        public string NameTag { get => _nameTag; set => _nameTag = value; }
        public string Color { get => _color; set => _color = value; }
        public string Group { get => _group; set => _group = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public float Weight { get => _weight; set => _weight = value; }
    }
}
