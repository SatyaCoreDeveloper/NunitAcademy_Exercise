using System;
using System.Collections.Generic;
using System.Text;

namespace NunitAcademy.Core.Fundamentals
{
    public class Reservation
    {
        public User ReservedBy { get; set; }

        public Reservation(User user)
        {
            ReservedBy = user;
        }

        public bool CanbeCancelled(User user)
        {
            if (user is null)
                throw new ArgumentNullException();
            return (user.IsAdmin || ReservedBy.Equals(user));
        }

        public void MakeReservedByUserAdmin()
        {
            ReservedBy.IsAdmin = true;
        }

    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}
