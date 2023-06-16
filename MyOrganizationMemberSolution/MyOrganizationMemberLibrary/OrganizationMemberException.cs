using System;

namespace MyOrganizationMemberLibrary
{
    public class OrganizationMemberException : ApplicationException
    {
        public OrganizationMemberException() : base() { }

        public OrganizationMemberException(string message) : base(message) { }

        public OrganizationMemberException(string message, Exception innerException) : base(message, innerException) { }
    }
}
