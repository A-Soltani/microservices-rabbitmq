using System.ComponentModel.DataAnnotations;

namespace MessageContract
{
    public enum PushNotificationType
    {
        /// <summary>
        /// فایل ارسالی دارای ستون شماره موبایل است.
        /// </summary>
        MobileNo = 1,
        /// <summary>
        /// فایل ارسالی دارای ستون کد شناسه شماره موبایل است.
        /// </summary>
        MobileId = 2,
        /// <summary>
        /// فایل ارسالی دارای ستون کد شناسه موبایل اپلیکیشن است
        /// </summary>
        MobileAppId = 3,
        /// <summary>
        /// ارسال به تمام مشترکین
        /// </summary>
        SendAllSubscriber = 9
    }
}