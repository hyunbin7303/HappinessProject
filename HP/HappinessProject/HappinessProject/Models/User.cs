

using System.Collections.Generic;

namespace HappinessProject.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public string FullAddress
        {
            get
            {
                return $"{ StreetAddress }, { City }, { State }  { ZipCode }";
            }
        }
    }
    public class User
    {
        public int user_id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string user_description { get; set; }
        public Address address { get; set; } // Primary Address
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public IList<UserReview> Reviews { get; set; }

    }
    public class UserReview
    {
        public int Id { get; set; }
        public string ReviewName { get; set; }
        public string ReviewContent { get; set; }
    }
}
