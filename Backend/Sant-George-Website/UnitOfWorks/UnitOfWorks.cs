﻿using System.Runtime.CompilerServices;
using Sant_George_Website.Repositories.Implementations;
using Sant_George_Website.Repositories.Interfaces;
using SantGeorgeWebsite.Models;
using SantGeorgeWebsite.Repositories.Implementations;
using SantGeorgeWebsite.Repositories.Interfaces;

namespace Sant_George_Website.UnitOfWorks
{
    public class UnitOfWorks : IUnitOfWorks
    {
        SantGeorgeWebsiteDBContext _context { get; }
        public UnitOfWorks(SantGeorgeWebsiteDBContext context )
        {
            _context = context;
        }

        ICommentRepository commentRepository;
        public ICommentRepository CommentRepository { 
            get
            {
                if(commentRepository == null) commentRepository = new CommentRepository(_context);
                return commentRepository;
            } 
        }

        IExamRepository examRepository;
        public IExamRepository ExamRepository
        {
            get
            {
                if (examRepository == null) examRepository = new ExamRepository(_context);
                return examRepository;
            }
        }


        IPhonenumberRepository phonenumberRepository;
        public IPhonenumberRepository PhonenumberRepository
        {
            get
            {
                if (phonenumberRepository == null) phonenumberRepository = new PhonenumberRepository(_context);
                return phonenumberRepository;
            }
        }

        IPostRepository postRepository;
        public IPostRepository PostRepository
        {
            get
            {
                if (postRepository == null) postRepository = new PostRepository(_context);
                return postRepository;
            }
        }



        IQuestionRepository questionRepository;
        public IQuestionRepository QuestionRepository
        {
            get
            {
                if (questionRepository == null) questionRepository = new QuestionRepository(_context);
                return questionRepository;
            }
        }

        IServiceRepository serviceRepository;
        public IServiceRepository ServiceRepository
        {
            get
            {
                if (serviceRepository == null) serviceRepository = new ServiceRepository(_context);
                return serviceRepository;
            }
        }

        IStudentAnswerChooseRepository studentAnswerChooseRepository;
        public IStudentAnswerChooseRepository StudentAnswerChooseRepository
        {
            get
            {
                if (studentAnswerChooseRepository == null) studentAnswerChooseRepository = new StudentAnswerChooseRepository(_context);
                return studentAnswerChooseRepository;
            }
        }
        IStudentAnswerTextRepository studentAnswerTextRepository;
        public IStudentAnswerTextRepository StudentAnswerTextRepository
        {
            get
            {
                if (studentAnswerTextRepository == null) studentAnswerTextRepository = new StudentAnswerTextRepository(_context);
                return studentAnswerTextRepository;
            }
        }

        IStudentAssignedExamRepository studentAssignedExamRepository;
        public IStudentAssignedExamRepository StudentAssignedExamRepository
        {
            get
            {
                if (studentAssignedExamRepository == null) studentAssignedExamRepository = new StudentAssignedExamRepository(_context);
                return studentAssignedExamRepository;
            }
        }

        ITeacherMarkExamRepository teacherMarkExamRepository;
        public ITeacherMarkExamRepository TeacherMarkExamRepository
        {
            get
            {
                if (teacherMarkExamRepository == null) teacherMarkExamRepository = new TeacherMarkExamRepository(_context);
                return teacherMarkExamRepository;
            }
        }

        IUserParentRepository userParentRepository;
        public IUserParentRepository UserParentRepository
        {
            get
            {
                if (userParentRepository == null) userParentRepository = new UserParentRepository(_context);
                return userParentRepository;
            }
        }
        IUserServiceRoleRepository userServiceRoleRepository;
        public IUserServiceRoleRepository UserServiceRoleRepository
        {
            get
            {
                if (userServiceRoleRepository == null) userServiceRoleRepository = new UserServiceRoleRepository(_context);
                return userServiceRoleRepository;
            }
        }

        IStudentAnswerTextRepository studentAnswerTextpository;

        public IStudentAnswerTextRepository StudentAnswerTextpository
        {
            get
            {
                if (studentAnswerTextpository == null) studentAnswerTextpository = new StudentAnswerTextRepository(_context);
                return studentAnswerTextpository;
            }
        }
        public async Task SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
