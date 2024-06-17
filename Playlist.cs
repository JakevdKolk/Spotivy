using System;


    public class Playlist
    {
        public string Name { get; set; }
        public List<Number> Numbers { get; set; }

        public void RemoveNumber(Number number)
        {
            Numbers.Remove(number);
        }
}
