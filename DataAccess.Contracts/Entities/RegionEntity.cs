using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Contracts.Entities
{
    public class RegionEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class DistrictEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class AddressEntity
    {
        public int Id { get; set; }
        public string Street { get; set; }

        public string Number { get; set; }

        public string Flat { get; set; }

        public string FlatNumber { get; set; }

        public string Block { get; set; }
    }

    public class PersonEntity
    {
        public int Id { get; set; }

        public string RUN { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Surname2 { get; set; }

        public DateTime DOB { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}
