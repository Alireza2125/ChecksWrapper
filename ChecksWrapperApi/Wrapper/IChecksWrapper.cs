using ChecksWrapperApi.Models;

using Refit;

namespace ChecksWrapperApi.Wrapper
{
    public interface IChecksWrapper
    {
        [Post("/user/add-user/")]
        Task<AddUserResponse> UserAddUser([Header("apiKey")] string apiKey, AddUserRequest request);

        [Multipart]
        [Post("/kyc-service/start-kyc-with-image/")]
        Task<MessageResponse> KycServiceStartKycWithImage([AliasAs("image")] StreamPart image, [AliasAs("video")] StreamPart video);

        [Post("/kyc-service/start-kyc-with-nationalCode-and-DownloadLink/")]
        Task<MessageResponse> KycServiceStartKycWithNationalCodeAndDownloadLink(StartKycWithNationalCodeAndDownloadLinkRequest request);

        [Post("/kyc-service/get-output-type1/")]
        Task<GetOutputType1Response> KycServiceGetOutputType1(GetOutputRequest request);

        [Post("/kyc-service/get-output-type2/")]
        Task<GetOutputType2Response> KycServiceGetOutputType2(GetOutputRequest request);

        [Multipart]
        [Post("/passport-ocr-service/start-ocr/")]
        Task<MessageResponse> PassportOcrServiceStartOcr([AliasAs("image")] StreamPart image);

        [Post("/passport-ocr-service/get-output/")]
        Task<OutputResponse> PassportOcrServiceGetOutput(GetOutputRequest request);

        [Multipart]
        [Post("/national-identification-ocr/nationalCard/full/")]
        Task<MessageResponse> NationalIdentificationOcrNationalCardFull([AliasAs("front_image")] StreamPart front_image, [AliasAs("back_image")] StreamPart back_image);

        [Multipart]
        [Post("/national-identification-ocr/nationalCard/one-page/")]
        Task<MessageResponse> NationalIdentificationOcrNationalCardOnePage([AliasAs("image")] StreamPart image);

        [Multipart]
        [Post("/national-identification-ocr/IdCard/")]
        Task<MessageResponse> NationalIdentificationOcrIdCard([AliasAs("image")] StreamPart image);

        [Post("/national-identification-ocr/get-output/")]
        Task<NationalIdentificationOcrGetOutput> NationalIdentificationOcrGetOutput(GetOutputRequest request);

        [Post("/national/national-code-and-birthdate/")]
        Task<NationalCodeResponse> NationalNationalCodeAndBirthdate(NationalCodeAndBirthdateRequest request);

        [Post("/national/post-code/")]
        Task<PostCodeResponse> NationalPostCode(PostCodeRequest request);

        [Post("/callBackService/")]
        Task<string> CallBackService();

        [Post("/ping/")]
        Task<string> Ping();
    }
}
