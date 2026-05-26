using System.Collections.Generic;

namespace Library
{
    // Clase abstracta sobre el Media
    public abstract class Media: IMedia
    {
        //Atributos
        private string name;
        public string Name
        {
            get {return this.name;} set {this.name = value;}
        }
        private double calification;
        public double Calification
        {
            get {return this.calification;} set {this.calification = value;}
        }

        private List<Tag> tags {get; set;}
        public List<Tag> Tags {get {return this.tags;} set {this.tags = value;}}
    }
}