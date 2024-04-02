using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Services.Appointment;
using TheBeautyForum.Tests.Mocks;
using TheBeautyForum.Web.ViewModels.Appointment;

namespace TheBeautyForum.Tests.Services
{
    [TestFixture]
    public class AppointmentServiceTests
    {
        [Test]
        public async Task GetAppointment_ReturnsAppointmentsById()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            Guid appointmentId = Guid.NewGuid();

            data.Appointments.Add(new Appointment()
            {
                Id = appointmentId,
                CategoryId = Guid.NewGuid(),
                StudioId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                Description = "Testtesttesttest",
                Studio = new Studio()
                {
                    Name = "Test",
                    CloseTime = TimeOnly.MaxValue,
                    OpenTime = TimeOnly.MinValue,
                    Description = "testtesttest",
                    Location = "testtesttest",
                    StudioPictureUrl = "testtest",
                    IsApproved = true,
                    UserId = Guid.NewGuid()
                },
                User = new User()
                {
                    FirstName = "Test",
                    LastName = "Test",
                    Email = "test@mail.com",
                    UserRole = "User"
                },
                Category = new Category()
                {
                    Name = "test"
                },
            });
            data.Appointments.Add(new Appointment()
            {
                Id = Guid.NewGuid(),
                CategoryId = Guid.NewGuid(),
                StudioId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                Description = "Testtesttesttest",
                Studio = new Studio()
                {
                    Id = Guid.NewGuid(),
                    Name = "Test",
                    CloseTime = TimeOnly.MaxValue,
                    OpenTime = TimeOnly.MinValue,
                    Description = "testtesttest",
                    Location = "testtesttest",
                    StudioPictureUrl = "testtest",
                    IsApproved = true,
                    UserId = Guid.NewGuid()
                },
                User = new User()
                {
                    FirstName = "Test",
                    LastName = "Test",
                    Email = "test@mail.com",
                    UserRole = "User"
                },
                Category = new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "test"
                },
            });

            data.SaveChanges();

            var appointmentService = new AppointmentService(data);

            #endregion

            #region Act

            var result = await appointmentService.GetAppointmentAsync(appointmentId);

            #endregion

            #region Assert

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<CreateAppointmentViewModel>());

            #endregion
        }

        [Test]
        public async Task GetAppointment_ThrowsIfIdIsNonExistent()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            data.Appointments.Add(new Appointment()
            {
                Id = Guid.NewGuid(),
                CategoryId = Guid.NewGuid(),
                StudioId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                Description = "Testtesttesttest",
                Studio = new Studio()
                {
                    Name = "Test",
                    CloseTime = TimeOnly.MaxValue,
                    OpenTime = TimeOnly.MinValue,
                    Description = "testtesttest",
                    Location = "testtesttest",
                    StudioPictureUrl = "testtest",
                    IsApproved = true,
                    UserId = Guid.NewGuid()
                },
                User = new User()
                {
                    FirstName = "Test",
                    LastName = "Test",
                    Email = "test@mail.com",
                    UserRole = "User"
                },
                Category = new Category()
                {
                    Name = "test"
                },
            });

            data.SaveChanges();

            var appointmentService = new AppointmentService(data);

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
                => await appointmentService.GetAppointmentAsync(Guid.NewGuid()));

            #endregion
        }

        [Test]
        public async Task CreateAppointment_CorrectRequest()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;
            var studioId = Guid.NewGuid();
            var userId = Guid.NewGuid();

            data.Studios.Add(new Studio()
            {
                Id = studioId,
                Name = "Test",
                Description = "Testtesttesttest",
                Location = "testtest"
            });

            data.SaveChanges();

            var request = new CreateAppointmentViewModel
            {
                CategoryId = Guid.NewGuid(),
                StudioId = studioId,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                StartDateHour = 2,
                Description = "TestDescTestDescTestDescTestDescTestDesc",
            };

            var appointmentService = new AppointmentService(data);

            #endregion

            #region Act

            await appointmentService.CreateAppointmentAsync(request, studioId, userId);

            var appointment = await data.Appointments
                .Where(a => a.Description == request.Description)
                .Where(a => a.CategoryId == request.CategoryId)
                .Where(a => a.StudioId == request.StudioId)
                .Where(a => a.UserId == userId)
                .Where(a => a.StartDate == request.StartDate)
                .Where(a => a.EndDate == request.StartDate.AddHours(1))
                .FirstOrDefaultAsync();

            #endregion

            #region Assert

            Assert.That(appointment, Is.Not.Null);

            #endregion
        }

        [Test]
        public async Task CreateAppointment_ThrowsIfRequestIsNull()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var appointmentService = new AppointmentService(data);

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await appointmentService.CreateAppointmentAsync(null, Guid.NewGuid(), Guid.NewGuid()));

            #endregion
        }

        [Test]
        public async Task CreateAppointment_ThrowsIfStudioIsNull()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;
            var studioId = Guid.NewGuid();
            var userId = Guid.NewGuid();

            var request = new CreateAppointmentViewModel
            {
                CategoryId = Guid.NewGuid(),
                StudioId = studioId,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                StartDateHour = 2,
                Description = "TestDescTestDescTestDescTestDescTestDesc",
            };

            var appointmentService = new AppointmentService(data);

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
                           => await appointmentService.CreateAppointmentAsync(request, studioId, userId));
            #endregion
        }

        [Test]
        public async Task DeleteAppointment_CorrectRequest()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var appointmentId = Guid.NewGuid();

            data.Appointments.Add(new Appointment()
            {
                Id = appointmentId,
                CategoryId = Guid.NewGuid(),
                StudioId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                Studio = new Studio
                {
                    Id = Guid.NewGuid(),
                    UserId = Guid.NewGuid(),
                    Name = "StudioTest",
                    Location = "TestLocation",
                    OpenTime = TimeOnly.MinValue,
                    CloseTime = TimeOnly.MaxValue,
                    Description = "TestDescTestDescTestDescTestDescTestDesc",
                    StudioPictureUrl = "test"
                },
                User = new User
                {
                    UserName = "UserTest",
                    FirstName = "TestName",
                    LastName = "TestTest",
                    Email = "Test@gmail.com",
                    PhoneNumber = "0899999999",
                    UserRole = "User"
                },
                Category = new Category() { Name = "Test" }
            });

            data.SaveChanges();

            var appointmentService = new AppointmentService(data);

            #endregion

            #region Act

            await appointmentService.DeleteAppointmentAsync(appointmentId);

            var appointment = await data.Appointments
                .FirstOrDefaultAsync();

            #endregion

            #region Assert

            Assert.That(appointment, Is.Null);

            #endregion
        }

        [Test]
        public async Task DeleteAppointment_ThrowsIfIdIsNonExistent()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var appointmentService = new AppointmentService(data);

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await appointmentService.DeleteAppointmentAsync(Guid.NewGuid()));

            #endregion
        }

        [Test]
        public async Task EditAppointment_CorrectRequest()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var appointmentId = Guid.NewGuid();
            var studioId = Guid.NewGuid();

            data.Appointments.Add(new Appointment()
            {
                Id = appointmentId,
                CategoryId = Guid.NewGuid(),
                StudioId = studioId,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddHours(1),
                Studio = new Studio
                {
                    Id = studioId,
                    UserId = Guid.NewGuid(),
                    Name = "StudioTest",
                    Location = "TestLocation",
                    OpenTime = TimeOnly.MinValue,
                    CloseTime = TimeOnly.MaxValue,
                    Description = "TestDescTestDescTestDescTestDescTestDesc",
                    StudioPictureUrl = "TestImage"
                },
                Category = new Category() { Name = "Test" }
            });

            data.SaveChanges();

            var appointmentService = new AppointmentService(data);

            var request = new CreateAppointmentViewModel
            {
                CategoryId = Guid.NewGuid(),
                StudioId = studioId,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                Description = "NewDescriptionTestNewDescriptionTestNewDescriptionTest"
            };

            #endregion

            #region Act

            await appointmentService.EditAppointmentAsync(appointmentId, request);

            var appointment = await data.Appointments
                .Where(a => a.CategoryId == request.CategoryId)
                .Where(a => a.StudioId == request.StudioId)
                .Where(a => a.StartDate == request.StartDate)
                .Where(a => a.EndDate == request.EndDate)
                .Where(a => a.Description == request.Description)
                .FirstOrDefaultAsync();

            #endregion

            #region Assert

            Assert.That(appointment, Is.Not.Null);

            #endregion
        }

        [Test]
        public async Task EditAppointment_ThrowsIfIdIsNonExistent()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var request = new CreateAppointmentViewModel()
            {
                CategoryId = Guid.NewGuid(),
                StudioId = Guid.NewGuid(),
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
            };

            var appointmentService = new AppointmentService(data);

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await appointmentService.EditAppointmentAsync(Guid.NewGuid(), request));

            #endregion
        }

        [Test]
        public async Task EditAppointment_ThrowsIfRequestIsNull()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var appointmentService = new AppointmentService(data);

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await appointmentService.EditAppointmentAsync(Guid.NewGuid(), null));

            #endregion
        }

        [Test]
        public async Task LoadCategories_CorrectRequest()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var appointmentId = Guid.NewGuid();
            var studioId = Guid.NewGuid();

            data.Studios.Add(new Studio()
            {
                Id = studioId,
                Name = "Test",
                Description = "Testtesttesttest",
                Location = "testtest",
                OpenTime = TimeOnly.MinValue,   
                CloseTime = TimeOnly.MaxValue,
                StudioPictureUrl = "test"
            });

            data.StudiosCategories.Add(new StudioCategory()
            {
                StudioId = studioId,
                CategoryId = Guid.NewGuid(),
                Category = new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Test",
                }
            });
            data.StudiosCategories.Add(new StudioCategory()
            {
                StudioId = studioId,
                CategoryId = Guid.NewGuid(),
                Category = new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Test",
                }
            });

            data.SaveChanges();

            var appointmentService = new AppointmentService(data);

            #endregion

            #region Act

            var model = await appointmentService.LoadCategoriesAsync(studioId);

            #endregion

            #region Assert

            Assert.That(model, Is.Not.Null);
            Assert.That(model.Categories.Count(), Is.EqualTo(2));

            #endregion
        }

        [Test]
        public async Task LoadCategories_ThrowsIfStudioIdIsNonExistent()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var appointmentId = Guid.NewGuid();
            var studioId = Guid.NewGuid();

            data.StudiosCategories.Add(new StudioCategory()
            {
                StudioId = studioId,
                CategoryId = Guid.NewGuid(),
                Category = new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Test",
                }
            });
            data.StudiosCategories.Add(new StudioCategory()
            {
                StudioId = studioId,
                CategoryId = Guid.NewGuid(),
                Category = new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Test",
                }
            });

            data.SaveChanges();

            var appointmentService = new AppointmentService(data);

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
                => await appointmentService.LoadCategoriesAsync(studioId));

            #endregion
        }
    }
}
