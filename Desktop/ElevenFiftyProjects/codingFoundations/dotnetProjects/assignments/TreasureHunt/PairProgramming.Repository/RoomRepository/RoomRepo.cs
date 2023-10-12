using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using PairProgramming.Data.Entities.CaveEntities;

namespace PairProgramming.Repository.RoomRepository
{
    public class RoomRepo
    {
        // get list of challenges
        // private readonly ChallengeRepo _levelChallengeRepo = new ChallengeRepo(); //todo: add ChallengeRepo

        //fake DB
        public List<Room> _roomDb = new List<Room>();
        int _count = 0;

        public RoomRepo()
        {
            SeedRoom();
        }

     
        //add
        public bool AddRoom(Room room)
        {

            if(room is null)
            {
                return false;
            }
            else
            {
                _count++;
                room.ID = _count;
                _roomDb.Add(room);
                return true;

            }

        }
        

        //get
        public List<Room> GetRooms()
        {
            return _roomDb;
        }
        public Room GetRoom(int id)
        {
            foreach (Room room in _roomDb)
            {
                if(room.ID == id)
                return room;
            }
            return null!;
        }

        //seed floors
        private void SeedRoom()
        {
            var Room0 = new Room()
            {
                ID = 0,
                Name = "Cave Entrance",
                //todo: add Challenges
            };
            var Room1 = new Room()
            {
                ID = 1,
                Name = "Room 1",
                //todo: add Challenges
            };
            var Room2 = new Room()
            {
                ID = 2,
                Name = "Room 2",
                //todo: add Challenges
            };
            var Room3 = new Room()
            {
                ID = 3,
                Name = "Room 3",
                //todo: add Challenges
            };
            var Room4 = new Room()
            {
                ID = 4,
                Name = "Room 4",
                //todo: add Challenges
            };

            _roomDb.Add(Room0);
            _roomDb.Add(Room1);
            _roomDb.Add(Room2);
            _roomDb.Add(Room3);
            _roomDb.Add(Room4);
        }
    }
}