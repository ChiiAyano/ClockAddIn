// Guids.cs
// MUST match guids.h
using System;

namespace Company.ClockAddIn
{
    static class GuidList
    {
        public const string guidClockAddInPkgString = "b94c1953-06d8-454e-83fa-1d7ee8164491";
        public const string guidClockAddInCmdSetString = "cba3e9ea-9c65-43c4-aec0-ca8144a9b4d4";
        public const string guidToolWindowPersistanceString = "fa8a36e0-bf4d-4c9c-8ce6-ed4557038b1c";

        public static readonly Guid guidClockAddInCmdSet = new Guid(guidClockAddInCmdSetString);
    };
}