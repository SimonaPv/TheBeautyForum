namespace TheBeautyForum.Data
{
    /// <summary>
    /// Represents helpful constants.
    /// </summary>
    public static class DataConstants
    {
        /// <summary>
        /// Represents helpful constants for appointment.
        /// </summary>
        public static class Appointment
        {
            /// <summary>
            /// Appointment's description maximum value.
            /// </summary>
            public const int DESCRIPTION_MAX_LENGTH = 25;

            /// <summary>
            /// Appointment's description minimum value.
            /// </summary>
            public const int DESCRIPTION_MIN_LENGTH = 5;
        }

        /// <summary>
        /// Represents helpful constants for category.
        /// </summary>
        public static class Category
        {
            /// <summary>
            /// Category's name maximum value.
            /// </summary>
            public const int NAME_MAX_LENGTH = 30;

            /// <summary>
            /// Category's name minimum value.
            /// </summary>
            public const int NAME_MIN_LENGTH = 3;
        }

        /// <summary>
        /// Represents helpful constants for rating.
        /// </summary>
        public static class Rating
        {
            /// <summary>
            /// Rating's maximum value.
            /// </summary>
            public const decimal RATING_MAX_VALUE = 5.0m;

            /// <summary>
            /// Rating's minimum value.
            /// </summary>
            public const decimal RATING_MIN_VALUE = 0.0m;
        }

        /// <summary>
        /// Represents helpful constants for studio.
        /// </summary>
        public static class Studio
        {
            /// <summary>
            /// Studio's name maximum value.
            /// </summary>
            public const int NAME_MAX_LENGTH = 25;

            /// <summary>
            /// Studio's name minimum value.
            /// </summary>
            public const int NAME_MIN_LENGTH = 2;

            /// <summary>
            /// Studio's description maximum value.
            /// </summary>
            public const int DESCRIPTION_MAX_LENGTH = 50;

            /// <summary>
            /// Studio's description minimum value.
            /// </summary>
            public const int DESCRIPTION_MIN_LENGTH = 10;

            /// <summary>
            /// Studio's location maximum value.
            /// </summary>
            public const int LOCATION_MAX_LENGTH = 80;

            /// <summary>
            /// Studio's location maximum value.
            /// </summary>
            public const int LOCATION_MIN_LENGTH = 10;

            /// <summary>
            /// Studio's image maximum value.
            /// </summary>
            public const int IMAGE_MAX_LENGTH = 2048;
        }

        /// <summary>
        /// Represents helpful constants for user.
        /// </summary>
        public static class User
        {
            /// <summary>
            /// Studio's first name maximum value.
            /// </summary>
            public const int FIRST_NAME_MAX_LENGTH = 30;

            /// <summary>
            /// Studio's first name minimum value.
            /// </summary>
            public const int FIRST_NAME_MIN_LENGTH = 2;

            /// <summary>
            /// Studio's last name maximum value.
            /// </summary>
            public const int LAST_NAME_MAX_LENGTH = 30;

            /// <summary>
            /// Studio's last name minimum value.
            /// </summary>
            public const int LAST_NAME_MIN_LENGTH = 2;
        }

        /// <summary>
        /// Represents helpful constants for publication.
        /// </summary>
        public static class Publication
        {
            /// <summary>
            /// Publication's description maximum value.
            /// </summary>
            public const int DESCRIPTION_MAX_LENGTH = 300;

            /// <summary>
            /// Publication's description minimum value.
            /// </summary>
            public const int DESCRIPTION_MIN_LENGTH = 0;

            /// <summary>
            /// Publication's image maximum value.
            /// </summary>
            public const int IMAGE_MAX_LENGTH = 2048;
        }
    }
}
