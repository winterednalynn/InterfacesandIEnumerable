using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesandIEnumerable
{
    internal class Program
    {//EDNA LYNN LAXA 
     // PROGRAMMING III Interfaces & IEnumerable Assignment 
     //JUNE 13,2023 
        static void Main(string[] args)
        {
            //Focusing on BeautySchool class to prompt the list that it possess through the Student Artist list. 
            BeautySchool beautySchool = new BeautySchool();

            //Using For Each b/c this will go through the list & implement the Ienumerable / Ienumerator rule of thumb that was placed into our B School Class. 
            //This code should display our Student artist. 
            foreach (StudentArtist studentArtist in beautySchool)
            {
                Console.WriteLine(studentArtist);
                Console.WriteLine(); //Spacing the name between each other for easy read. 
            }
        }
    }
}
