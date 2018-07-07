using EventsReminder.Common.ValidationAttributes;
using Microsoft.AspNetCore.Mvc.Rendering;
using NUnit.Framework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EventsReminder.UnitTests.ValidationAttributes
{
    [TestFixture]
    public class SelectListItemIsRequiredAttributeTests
    {
        ValidationTargetForRequiredSelectListItem _model;
        ValidationContext _context;
        List<ValidationResult> _validationResults;

        [SetUp]
        public void SetUp()
        {
            _model = new ValidationTargetForRequiredSelectListItem();
            _context = new ValidationContext(_model);
            _validationResults = new List<ValidationResult>();
        }

        [Test]
        public void SelectListItemIsRequiredAttribute_PassNullValue_ValidationShouldFail()
        {
            var isValid = Validator.TryValidateObject(_model, _context, _validationResults, true);

            Assert.That(isValid, Is.False);
        }

        [Test]
        public void SelectListItemIsRequiredAttribute_PassAnEmptyList_ValidationShouldFail()
        {
            _model.RequiredField = new List<SelectListItem>();
            var isValid = Validator.TryValidateObject(_model, _context, _validationResults, true);

            Assert.That(isValid, Is.False);
        }

        [Test]
        public void SelectListItemIsRequiredAttribute_PassNotEmptyListListButWithoutSelectedItem_ValidationShouldFail()
        {
            _model.RequiredField = new List<SelectListItem>()
            {
                new SelectListItem() { Text = "Example value 1", Value = "Example 1" },
                new SelectListItem() { Text = "Example value 2", Value = "Example 2" }
            };
            var isValid = Validator.TryValidateObject(_model, _context, _validationResults, true);

            Assert.That(isValid, Is.False);
        }

        [Test]
        public void SelectListItemIsRequiredAttribute_PassNotEmptyListListWithSelectedItem_ValidationShouldBeSuccessful()
        {
            _model.RequiredField = new List<SelectListItem>()
            {
                new SelectListItem() { Text = "Example value 1", Value = "Example 1" },
                new SelectListItem() { Text = "Example value 2", Value = "Example 2", Selected = true }
            };
            var isValid = Validator.TryValidateObject(_model, _context, _validationResults, true);

            Assert.That(isValid, Is.True);
        }
    }

    class ValidationTargetForRequiredSelectListItem
    {
        [SelectListItemIsRequired]
        public List<SelectListItem> RequiredField { get; set; }
    }
}
