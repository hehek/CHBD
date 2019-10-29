using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoomsBL
{
     public class ChatRoomsEF : iChatRoomsDAL
    {
        ChatEntities _context;
        
        public ChatRoomsEF()
        {
            _context = new ChatEntities();

        }

        public  void AddRoom(string name)
        {          
            var newRoom = _context.Rooms.Create();
            newRoom.Name = name;
            _context.Rooms.Add(newRoom);
            _context.SaveChanges();
        }
        public void AddRole(int roomID, int roleID)
        {
            var room = _context.Users.Find(roomID);
            if (room != null)
            {
                var newRole = _context.Roles.Create();
                newRole.RoleID = roleID;
                room.Roles.Add(newRole);
              
                _context.SaveChanges();
            }
        }
        public void DeleteRoom( int roomID)
        {
            var room = _context.Rooms.Find(roomID);
            if  (room != null)
            {
                _context.Rooms.Remove(room);
                _context.SaveChanges();
            }
        }

       
        //public void AddUser(int roomID ,string name, bool sex, DateTime dateOfBirth, byte[] Photo)
        //{
        //    var room = _context.Users.Find(roomID);

        //    if (room != null)
        //    {
        //        var newUser = _context.Users.Create();
        //        newUser.Name = name;
        //        newUser.Sex = sex;
        //        newUser.DateOfBirthday = dateOfBirth;
        //        newUser.Photo = Photo;
        //       room.
        //        _context.SaveChanges();
        //    }


    }

    }
}
