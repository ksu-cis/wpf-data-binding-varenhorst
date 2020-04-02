using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace UniversityRegistry.Data
{
    /// <summary>
    /// A class representing a person associated with the university
    /// </summary>
    public class Person : INotifyPropertyChanged
    {
        /// <summary>
        /// Event that is triggerd when properties of Person change.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The next ID to assign to a newly-created person
        /// </summary>
        public static uint NextID = 80000000;

        /// <summary>
        /// The uinque identifier of this person
        /// </summary>
        public uint ID { get; private set; }


        private string firstName;
        /// <summary>
        /// The person's first name
        /// </summary>
        public string FirstName {
            get 
            {
                return firstName;
            }
            set
            {
                if (firstName == value)
                {
                    return;
                }
                firstName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FirstName"));
            }
        }

        private string lastName;
        /// <summary>
        /// The person's last name
        /// </summary>
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (lastName == value)
                {
                    return;
                }
                lastName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LastName"));
            }
        }

        public DateTime dob;
        /// <summary>
        /// The person's date of birth
        /// </summary>
        public DateTime DateOfBirth
        {
            get
            {
                return dob;
            }
            set
            {
                if (dob == value)
                {
                    return;
                }
                dob = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DateOfBirth"));
            }
        }

        public bool active;
        /// <summary>
        /// If this person is active in the university (currently a part of the university)
        /// </summary>
        public bool Active
        {
            get
            {
                return active;
            }
            set
            {
                if (active == value)
                {
                    return;
                }
                active = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Active"));
            }
        }

        public Role role;
        /// <summary>
        /// The person's role
        /// </summary>
        public Role Role
        {
            get
            {
                return role;
            }
            set
            {
                if (role == value)
                {
                    return;
                }
                role = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Role"));
            }
        }
        
        /// <summary>
        /// Creates a new user, assigning them an ID
        /// </summary>
        public Person()
        {
            ID = NextID++;
        }

        /// <summary>
        /// Returns the string that identifies the person.
        /// </summary>
        /// <returns> a string with their first, and last name.</returns>
        public override string ToString()
        {
            return $"{LastName}, {FirstName} [{ID}]";
        }
    }
}
