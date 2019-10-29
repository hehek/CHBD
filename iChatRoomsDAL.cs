using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoomsBL
{
    interface iChatRoomsDAL
    {
      void AddRoom(string name);        

     // void AddUser(string name, bool sex, DateTime dateOfBirth, byte[] Photo);
        void AddRole(int roomID, int roleID);
        void DeleteRoom(int roomID);
    }
}
