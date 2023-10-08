using ChecksWrapperApi.Models;
using ChecksWrapperApi.Wrapper;

using Microsoft.AspNetCore.Mvc;

using Refit;

namespace ChecksWrapperApi.Controllers
{
    [ApiController]
    public class ChecksWrapperController : ControllerBase
    {
        private readonly IChecksWrapper _checksWrapper;

        public ChecksWrapperController(IChecksWrapper checksWrapper)
        {
            _checksWrapper = checksWrapper;
        }

        private static StreamPart FormFileToStreamPart(IFormFile formFile) =>
            new(formFile.OpenReadStream(), formFile.FileName, formFile.ContentType, formFile.Name);

        [HttpPost("/user/add-user/")]
        public Task<AddUserResponse> UserAddUser(string apiKey, AddUserRequest request) =>
            _checksWrapper.UserAddUser(apiKey, request);

        [HttpPost("/kyc-service/start-kyc-with-image/")]
        public Task<MessageResponse> KycServiceStartKycWithImage(IFormFile image, IFormFile video) =>
            _checksWrapper.KycServiceStartKycWithImage(FormFileToStreamPart(image), FormFileToStreamPart(video));

        [HttpPost("/kyc-service/start-kyc-with-nationalCode-and-DownloadLink/")]
        public Task<MessageResponse> KycServiceStartKycWithNationalCodeAndDownloadLink(StartKycWithNationalCodeAndDownloadLinkRequest request) =>
            _checksWrapper.KycServiceStartKycWithNationalCodeAndDownloadLink(request);


        [HttpPost("/kyc-service/get-output-type1/")]
        public Task<GetOutputType1Response> KycServiceGetOutputType1(GetOutputRequest request) =>
            _checksWrapper.KycServiceGetOutputType1(request);

        [HttpPost("/kyc-service/get-output-type2/")]
        public Task<GetOutputType2Response> KycServiceGetOutputType2(GetOutputRequest request) =>
            _checksWrapper.KycServiceGetOutputType2(request);


        [HttpPost("/passport-ocr-service/start-ocr/")]
        public Task<MessageResponse> PassportOcrServiceStartOcr(IFormFile image) =>
            _checksWrapper.PassportOcrServiceStartOcr(FormFileToStreamPart(image));

        [HttpPost("/passport-ocr-service/get-output/")]
        public Task<OutputResponse> PassportOcrServiceGetOutput(GetOutputRequest request) =>
            _checksWrapper.PassportOcrServiceGetOutput(request);


        [HttpPost("/national-identification-ocr/nationalCard/full/")]
        public Task<MessageResponse> NationalIdentificationOcrNationalCardFull(IFormFile front_image, IFormFile back_image) =>
            _checksWrapper.NationalIdentificationOcrNationalCardFull(FormFileToStreamPart(front_image), FormFileToStreamPart(back_image));


        [HttpPost("/national-identification-ocr/nationalCard/one-page/")]
        public Task<MessageResponse> NationalIdentificationOcrNationalCardOnePage(IFormFile image) =>
            _checksWrapper.NationalIdentificationOcrNationalCardOnePage(FormFileToStreamPart(image));


        [HttpPost("/national-identification-ocr/IdCard/")]
        public Task<MessageResponse> NationalIdentificationOcrIdCard(IFormFile image) =>
            _checksWrapper.NationalIdentificationOcrIdCard(FormFileToStreamPart(image));

        [HttpPost("/national-identification-ocr/get-output/")]
        public Task<NationalIdentificationOcrGetOutput> NationalIdentificationOcrGetOutput(GetOutputRequest request) =>
            _checksWrapper.NationalIdentificationOcrGetOutput(request);

        [HttpPost("/national/national-code-and-birthdate/")]
        public Task<NationalCodeResponse> NationalNationalCodeAndBirthdate(NationalCodeAndBirthdateRequest request) =>
            _checksWrapper.NationalNationalCodeAndBirthdate(request);

        [HttpPost("/national/post-code/")]
        public Task<PostCodeResponse> NationalPostCode(PostCodeRequest request) =>
            _checksWrapper.NationalPostCode(request);

        [HttpPost("/callBackService/")]
        public Task<string> CallBackService() =>
            _checksWrapper.CallBackService();

        [HttpPost("/ping/")]
        public Task<string> Ping() =>
            _checksWrapper.Ping();
    }
}
