using System.Web.Mvc;
using Moodle3KL.Data.Repositories;
using Moodle3KL.Domain;
using StudentCard.Web.UI.Models.Documentation.Details;
using Web.Common.App.Extensions;

namespace StudentCard.Web.UI.Controllers
{
    public class DocumentationController : Controller
    {
        public IMdlEntityRepositoryBase<mdl_study_document> MdlStudyDocumentRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_persons> MdlBlockDofSPersonsRepository { get; set; }

        [ChildActionOnly]
        public ActionResult Details(long studenId)
        {
            return PartialView("~/Views/Documentation/Details.cshtml", new DocumentationDetailsModel
            {
                StudentId = studenId
            });
        }

        [HttpPost]
        public ActionResult StudyDocument(long studentId)
        {
            var departmentId = MdlBlockDofSPersonsRepository.GetById(studentId, e => e.departmentid).Value;

            MdlStudyDocumentRepository.Save(new mdl_study_document
            {
                studentid = studentId,
                isapproved = false,
                isnew = true,
                departmentid = departmentId
            });

            MdlStudyDocumentRepository.Commit();

            return this.Ok();
        }
    }
}