﻿namespace PushbulletSharp
{
    public class PushbulletConstants
    {
        public const string BaseUrl = "https://api.pushbullet.com/v2/";

        public class HttpMethods
        {
            public const string GET = "GET";
            public const string POST = "POST";
            public const string DELETE = "DELETE";
        }

        public class PushRequestErrorMessages
        {
            public const string EmptyDeviceIdenProperty = "The device iden property for the reqeust is empty.";
            public const string EmptyTypeProperty = "The type property for the reqeust is empty. Not even sure how that happened.";
            public const string EmptyEmailProperty = "The email property for the request is empty. This is only a problem because the device iden was empty, too.";
        }


        public class PushNoteRequestErrorMessages
        {
            public const string EmptyTitleProperty = "The title property for the note request is empty. Please provide a title.";
            public const string EmptyBodyProperty = "The body property for the note request is empty. Please provide a body.";
        }


        public class PushAddressErrorMessages
        {
            public const string EmptyNameProperty = "The name property for the address request is empty. Please provide a name.";
            public const string EmptyAddressProperty = "The address property for the address request is empty. Please provide a name.";
        }


        public class PushLinkErrorMessages
        {
            public const string EmptyTitleProperty = "The title property for the link request is empty. Please provide a title.";
            public const string EmptyUrlProperty = "The url property for the link request is empty. Please provide a url.";
        }


        public class PushListErrorMessages
        {
            public const string EmptyTitleProperty = "The title property for the list request is empty. Please provide a title.";
        }


        public class PushFileErrorMessages
        {
            public const string ErrorMakingFileUploadRequest = "There was an error while making a request to upload the file to pushbullet.";
            public const string EmptyFileNameProperty = "The file_name property for the file request is empty. Please provide a file_name.";
            public const string EmptyFileTypeProperty = "The file_type property for the file request is empty. Please provide a file_type.";
            public const string EmptyFileStreamProperty = "The file_stream property for the file request is empty. Please provide a valid file_stream.";
            public const string EmptyBodyProperty = "The body property for the file request is empty. While this is optional, the way you are calling the PushFile method requires you to provide a body.";
            public const string CantReadFileStreamProperty = "The file_stream for the file request can't be read. Please provide a valid file_stream.";
        }


        public class CreateContactErrorMessages
        {
            public const string ErrorNameProperty = "The name property for creating a new contact is empty. Please provide a name.";
            public const string ErrorEmailProperty = "The email property for creating a new contact is empty. Please provide an email.";
        }


        public class UpdateContactErrorMessages
        {
            public const string ErrorContactIdenProperty = "The contact_iden property for updating a contact is empty. Please provide a valid contact_iden.";
            public const string ErrorNameProperty = "The name property for updating a contact is empty. Please provide a new name.";
        }


        public class DeleteContactErrorMessages
        {
            public const string ErrorContactIdenProperty = "The contact_iden property for deleting a contact is empty. Please provide a valid contact_iden.";
        }


        public class HeadersConstants
        {
            public const string AuthorizationKey = "Authorization";
            public const string AuthorizationValue = "Bearer {0}";
        }


        public class TypeConstants
        {
            public const string Note = "note";
            public const string Link = "link";
            public const string Address = "address";
            public const string List = "list";
            public const string File = "file";
        }


        public class UsersUrls
        {
            public const string Me = "users/me";
        }


        public class DevicesUrls
        {
            public const string Me = "devices";
        }


        public class PushesUrls
        {
            public const string Push = "pushes";
        }


        public class FileUrls
        {
            public const string UploadRequest = "upload-request";
            public const string AmazonAWS = "https://s3.amazonaws.com/pushbullet-uploads";
        }


        public class ContactsUrls
        {
            public const string Contacts = "contacts";
        }


        public class SubscriptionUrls
        {
            public const string Subscriptions = "subscriptions";
            public const string ChannelInfo = "channel-info";
        }

        
        public class AmazonHeaders
        {
            public const string ContentType = "Content-Type";
            public const string CacheControl = "Cache-Control";
            public const string CacheControlDefaultValue = "max-age=31556926";
        }


        public class MimeTypes
        {
            public const string Json = "application/json";
            public const string OctetStream = "application/octet-stream";
        }
    }
}