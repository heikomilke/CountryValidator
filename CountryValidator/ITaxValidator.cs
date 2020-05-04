﻿namespace CountryValidator
{
    public interface ITaxValidator
    {
        ValidationResult ValidateEntity(string vat, Country country);
        ValidationResult ValidateIndividualTaxCode(string id, Country country);
        ValidationResult ValidateNationalIdentityCode(string ssn, Country country);
        ValidationResult ValidateVAT(string vat, Country country);

    }
}
