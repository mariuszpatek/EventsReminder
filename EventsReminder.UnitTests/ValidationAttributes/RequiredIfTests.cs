using EventsReminder.Common.ValidationAttributes;
using NUnit.Framework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EventsReminder.UnitTests.ValidationAttributes
{
    [TestFixture]
    public class RequiredIfTests
    {
        ValidationTargetForRequiredIf _model;
        ValidationContext _context;
        List<ValidationResult> _validationResults;

        [SetUp]
        public void SetUp()
        {
            _model = new ValidationTargetForRequiredIf();
            _context = new ValidationContext(_model);
            _validationResults = new List<ValidationResult>();
        }

        [Test]
        public void RequiredIfAttribute_RequiredFieldIsEmptyAndXHasDesiredValue_ValidationShouldFail()
        {
            _model.X = "Required";

            var isValid = Validator.TryValidateObject(_model, _context, _validationResults, true);

            Assert.That(isValid, Is.False);
        }

        [Test]
        public void RequiredIfAttribute_RequiredFieldIsNoTEmptyAndXHasDesiredValue_ValidationShouldBeSuccessful()
        {
            _model.X = "Required";
            _model.RequiredField = "Some value";

            var isValid = Validator.TryValidateObject(_model, _context, _validationResults, true);

            Assert.That(isValid, Is.True);
        }

        [Test]
        public void RequiredIfAttribute_RequiredFieldIsNotEmptyAndXHasNoDesiredValue_ValidationShouldBeSuccessful()
        {
            _model.X = "Not Required";
            _model.RequiredField = "Some value";

            var isValid = Validator.TryValidateObject(_model, _context, _validationResults, true);

            Assert.That(isValid, Is.True);
        }

        [Test]
        public void RequiredIfAttribute_RequiredFieldIsEmptyButXHasHasNoDesiredValue_ValidationShouldBeSuccessful()
        {
            _model.X = "Not Required";

            var isValid = Validator.TryValidateObject(_model, _context, _validationResults, true);

            Assert.That(isValid, Is.True);
        }

        class ValidationTargetForRequiredIf
        {
            // If field "RequiredField" is required depends on value of this property 
            public string X { get; set; }

            [RequiredIf("X", "Required")]
            public string RequiredField { get; set; }
        }
    }
}
