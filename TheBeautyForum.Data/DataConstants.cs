namespace TheBeautyForum.Data
{
    public static class DataConstants
    {
        public static class Appointment
        {
            public const int DESCRIPTION_MAX_LENGTH = 300;

            public const int DESCRIPTION_MIN_LENGTH = 10;
        }

        public static class Category
        {
            public const int NAME_MAX_LENGTH = 50;

            public const int NAME_MIN_LENGTH = 3;
        }

        public static class Rating
        {
            public const decimal RATING_MAX_VALUE = 5.0m;

            public const decimal RATING_MIN_VALUE = 0.0m;
        }

        public static class Studio
        {
            public const int NAME_MAX_LENGTH = 50;

            public const int NAME_MIN_LENGTH = 2;

            public const int DESCRIPTION_MAX_LENGTH = 300;

            public const int DESCRIPTION_MIN_LENGTH = 10;

            public const int LOCATION_MAX_LENGTH = 80;

            public const int LOCATION_MIN_LENGTH = 10;

            public const int IMAGE_MAX_LENGTH = 2048;
        }

        public static class User
        {
            public const int FIRST_NAME_MAX_LENGTH = 30;

            public const int FIRST_NAME_MIN_LENGTH = 2;

            public const int LAST_NAME_MAX_LENGTH = 30;

            public const int LAST_NAME_MIN_LENGTH = 2;
        }

        public static class Publication
        {
            public const int DESCRIPTION_MAX_LENGTH = 300;

            public const int DESCRIPTION_MIN_LENGTH = 0;

            public const int IMAGE_MAX_LENGTH = 2048;
        }

        public static class Comment
        {
            public const int DESCRIPTION_MAX_LENGTH = 300;

            public const int DESCRIPTION_MIN_LENGTH = 3;
        }
    }
}
