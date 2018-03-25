using System.Collections.Generic;

namespace MoqExample
{
    public class Repository : IRepository
    {
        public List<Band> GetBands()
        {
            // this would communicate with a database to return data.
            var listOfBands = new List<Band>();

            listOfBands.Add(
                new Band {
                    Name = "Bayside",
                    Origin = "Queens, New York, USA",
                    Genre = "Alternative",
                    BestSong = "I And I"
                });

            listOfBands.Add(
                new Band {
                    Name = "Brand New",
                    Origin = "Long Island, New York, USA",
                    Genre = "Alternative",
                    BestSong = "The Quiet Things That No One Ever Knows"
                });

            listOfBands.Add(
                 new Band {
                     Name = "Senses Fail",
                     Origin = "Ridgewood, New Jersey, USA",
                     Genre = "Aternative",
                     BestSong = "Can't Be Saved"
                 });

            return listOfBands;
        }
    }
}
