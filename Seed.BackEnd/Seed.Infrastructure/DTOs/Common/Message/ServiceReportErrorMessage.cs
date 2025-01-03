
using Seed.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public static class ServiceReportErrorMessage
    {
        public static Error FieldIsEmpty(string nameField)
            => Error.Validation("ServiceReport.Empty", $"The '{nameField}' is required.");

        public static Error ReportNotExist()
            => Error.NotFound("ServiceReport.Exist", $"Service report does not exist.");

        public static Error ReportNotCreated()
            => Error.Conflict("ServiceReport.Create", $"Service report is not created.");

        public static Error ReportContentInvalidLength()
            => Error.Validation("ServiceReport.Content.Length", $"Report content must not exceed 1000 characters.");

        public static Error InvalidReportDate()
            => Error.Validation("ServiceReport.Date.Invalid", $"Report date must not be in the future.");

        public static Error RecommendationsInvalidLength()
            => Error.Validation("ServiceReport.Recommendations.Length", $"Recommendations must not exceed 500 characters.");

        public static Error ReportUpdateFailed()
            => Error.Conflict("ServiceReport.Update.Failed", $"Failed to update the service report.");

        public static Error ReportNotFound()
            => Error.NotFound("ServiceReport.NotFound", $"The service report with the given ID was not found.");

        public static Error ReportDeletionFailed()
            => Error.Conflict("ServiceReport.Delete.Failed", $"Failed to delete the service report.");

        // Add the missing PrescriptionIdRequired error message
        public static Error PrescriptionIdRequired()
            => Error.Validation("ServiceReport.Prescription.Required", $"Prescription ID is required when there is a prescription.");
        public static Error AppointmentNotExist()
            => Error.NotFound("ServiceReport.Appointment.NotExist", $"The appointment does not exist.");
        public static Error ReportCreationFailed() 
        => Error.Conflict("ServiceReport.Create.Failed", $"Failed to create the service report.");

    }


