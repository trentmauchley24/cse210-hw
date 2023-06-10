using System;

    public class person
    {
        public string _givenName;
        public string _familyName;
        public person()
        {
        }
            public void ShowEasternName(){
                Console.WriteLine($"{_familyName}, {_givenName}");
            }
            public void ShowWesternName(){
                Console.WriteLine($"{_givenName}, {_familyName}");
            }
        } 
    
