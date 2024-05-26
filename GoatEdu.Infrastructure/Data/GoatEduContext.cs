using System;
using System.Collections.Generic;
using GoatEdu.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infrastructure.Data
{
    public partial class GoatEduContext : DbContext
    {
        public DbSet<Achievement> Achievements { get; set; } = null!;
        public DbSet<Answer> Answers { get; set; } = null!;
        public DbSet<Calculation> Calculations { get; set; } = null!;
        public DbSet<Chapter> Chapters { get; set; } = null!;
        public DbSet<Discussion> Discussions { get; set; } = null!;
        public DbSet<Enrollment> Enrollments { get; set; } = null!;
        public DbSet<EnrollmentProcess> EnrollmentProcesses { get; set; } = null!;
        public DbSet<Flashcard> Flashcards { get; set; } = null!;
        public DbSet<FlashcardContent> FlashcardContents { get; set; } = null!;
        public DbSet<Lesson> Lessons { get; set; } = null!;
        public DbSet<Note> Notes { get; set; } = null!;
        public DbSet<Notification> Notifications { get; set; } = null!;
        public DbSet<QuestionInQuiz> QuestionInQuizzes { get; set; } = null!;
        public DbSet<Quiz> Quizzes { get; set; } = null!;
        public DbSet<Report> Reports { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<Subject> Subjects { get; set; } = null!;
        public DbSet<Subscription> Subscriptions { get; set; } = null!;
        public DbSet<Tag> Tags { get; set; } = null!;
        public DbSet<Theory> Theories { get; set; } = null!;
        public DbSet<TheoryFlashCardContent> TheoryFlashCardContents { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Vote> Votes { get; set; } = null!;
        public DbSet<Wallet> Wallets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=35.240.220.220;Port=5432;Username=root;Password=Admin123456789@;Database=goateduprimary;");
        }
    }
}
