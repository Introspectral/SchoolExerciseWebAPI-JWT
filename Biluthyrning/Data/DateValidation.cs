using System.ComponentModel.DataAnnotations;

namespace Biluthyrning.Data
{
	public class DateValidation : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			DateTime startDate = (DateTime)validationContext.ObjectType.GetProperty("StartDate").GetValue(validationContext.ObjectInstance, null);
			DateTime endDate = (DateTime)validationContext.ObjectType.GetProperty("EndDate").GetValue(validationContext.ObjectInstance, null);

			if (startDate > endDate)
			{
				return new ValidationResult("Startdatum måste vara innan slutdatum");
			}
			return ValidationResult.Success;
		}
	}
}
