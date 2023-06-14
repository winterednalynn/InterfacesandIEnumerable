using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesandIEnumerable
{
    public class BeautySchool : IEnumerable<StudentArtist> //INHERTIING IENUMERABLE THEN IMPLEMENT INTERFACE 
    {

        // IENUMERABLE 
        //THIS INTERFACE IS WHAT FOR EACH LOOKS FOR , TO LOOP THROUGH IT
        // ITS IN TWO PARTS 

        List<StudentArtist> _artist; //FIELDS , LIST 

        public BeautySchool()
        {
            //MY LIST OF ARTIST 
            _artist = new List<StudentArtist>();

            _artist.Add(new StudentArtist("Peach"));
            _artist.Add(new StudentArtist("Luigi"));
            _artist.Add(new StudentArtist("Yoshi"));
            _artist.Add(new StudentArtist("Toad"));
            _artist.Add(new StudentArtist("Daisy"));
            _artist.Add(new StudentArtist("Bowser"));
            _artist.Add(new StudentArtist("Wario"));
            _artist.Add(new StudentArtist("Walugi"));
            _artist.Add(new StudentArtist("Diddy"));
            _artist.Add(new StudentArtist("Rosalina"));
            _artist.Add(new StudentArtist("Toadette"));
            _artist.Add(new StudentArtist("KoopaTroopa"));
            _artist.Add(new StudentArtist("Goomba"));
            _artist.Add(new StudentArtist("Boo"));
            _artist.Add(new StudentArtist("ShyGirl"));
            _artist.Add(new StudentArtist("ShyGuy"));
            _artist.Add(new StudentArtist("Lemmy"));
            _artist.Add(new StudentArtist("Wendy"));
            _artist.Add(new StudentArtist("Iggy"));
            _artist.Add(new StudentArtist("Blessing"));
        }

        public List<StudentArtist> Artist { get => _artist; set => _artist = value; }

        public IEnumerator<StudentArtist> GetEnumerator() // This example wasn't in the video, I am uncertain if this was a correct implementation but it seem to work when displaying artist. 
        {
            for (int i = 0; i < _artist.Count; i++)
            {
                yield return _artist[i]; // YIELD RETURN: Yield is an iterator to provide next value / prompts of an end of iteration. 
            }
        }

        IEnumerator IEnumerable.GetEnumerator() // This is an interface method. 
        {
            return new BeautySchoolEnumerator(_artist); // This is the very constructor that was made for BeautySchoolEnumerator that is passing in the list. This is just basically stating that this is the list we like to access. 
        }

        public class BeautySchoolEnumerator : IEnumerator
        {
            List<StudentArtist> _artists;
            int index = -1; //Setting Index to -1 , why? : This is going to iterate first because as the move next method takes action it will ++ (move forward.) 

            public BeautySchoolEnumerator(List<StudentArtist> artists) // GENERATE CONSTRUCTOR w/ The list Student Artist, because we are creating a new instance. 
            {
                _artists = artists; //passing in value. 
               
            }

            public object Current => _artists[index]; //Building a property. Initially we couldn't build a field w/ our interface. This returning the index of our list = current item , just like a foreach. 

            public bool MoveNext()
            {
                index++; //Incrementing the index (moving forward in the list) 

                if (index >= _artists.Count) // if number of list is greater or equal to StudentArtist amount returns false. This check if were pass the end of list
                {
                    return false; // why false? This will trigger the reset , just in case our list breaks. 
                }
                else
                {
                    return true; // True , is telling the computer "we are not at the end of the list, keep going" 
                }
            }

            public void Reset() // the reset 
            {
                index = -1; // back to the start. 
            }
        }
    }
   
}
