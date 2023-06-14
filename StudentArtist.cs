using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesandIEnumerable
{
    public class StudentArtist //Specific class dedicated to Student List , Named StudentArtist. 
    {
        string _name; // One field. Name entry. 

        public StudentArtist(string name) //Constructor to pass in name 
        {
            _name = name;
        }

        public string Name { get => _name; set => _name = value; } //Property 

        //Overide to String , Identifying each name as Artist. 
        public override string ToString()
        {
            return $"Artist: {_name}"; 
        }
    }
}
