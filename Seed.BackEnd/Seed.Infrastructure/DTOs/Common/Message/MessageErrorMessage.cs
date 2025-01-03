
using Seed.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public static class MessageErrorMessage
    {
        public static Error WarningChat()
           => Error.Validation("Veterinarian.Warning", $"Only veterinarians can initiate chat.");
        public static Error InvalidDateChat()
            => Error.Validation("Customer.InvalidDate", $"The chat is no longer available after the appointment date.");
        public static Error PetUpdateImgFailed()
            => Error.Validation("Pet.UpdateImgFailed", "Failed to update Image for Pet.");
    }

