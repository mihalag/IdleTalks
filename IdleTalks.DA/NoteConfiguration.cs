// <auto-generated>
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace IdleTalks.DA
{
    // Note
    public class NoteConfiguration : EntityTypeConfiguration<Note>
    {
        public NoteConfiguration()
            : this("dbo")
        {
        }
 
        public NoteConfiguration(string schema)
        {
            ToTable(schema + ".Note");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("bigint").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.UserId).HasColumnName("UserId").IsRequired().HasColumnType("bigint");
            Property(x => x.Title).HasColumnName("Title").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Text).HasColumnName("Text").IsRequired().HasColumnType("nvarchar").HasMaxLength(1024);

            // Foreign keys
            HasRequired(a => a.User).WithMany(b => b.Notes).HasForeignKey(c => c.UserId); // FK_Note_User
        }
    }

}
// </auto-generated>
