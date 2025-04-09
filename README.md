# DotNetCore
<div>
<h2>معرفی دات نت کور و اینکه چرا باید آن را یاد بگیریم!</h2>
<ul style="direction:rtl;">
<li>1.open source</li>
<li>2.Cross PlatForm</li>
<li>3.Modular Architecture</li>
</ul>
<h2>چه چیز هایی را می اموزیم</h2>
<ul>
<li>Middleware </li>
<li>Dependency Injection </li>
<li>Routing </li>
<li> MVC Model </li>
</ul>

<h2>امنیت در Asp.net Core</h2>
<ul>
<li>احراز هویت </li>
<li>محافظت در برابر حملات رایج </li>
<li>مدیریت داده های حساس </li>

</ul>


<h2>معماری های رایج ASP.netCore</h2>
<ul>
<li>معماری پیازی repository </li>
<li>معماری تمیز Clean Architecutre </li>
<li>معماری لایه ای Layerd </li>
<li>معماری MicroService</li>
</ul>

<h2>افزودن  اولین پروژه</h2>
<ul>
<li>Asp.net Core Web App(Model-View-Contorller) </li>
<li> FrameWork: .NEt 8.0 </li>
<li> UnCheck Https </li>

</ul>

<h2>Context & Entities</h2>
<ul>
<li>Entities: Our class placed here </li>
<li> Context: Tools To connect With DB </li>


</ul>



<h2>Context </h2>
<ul>
<li>Add MyDbContext Class  </li>
<li> Add Nugets: Microsoft.EntityFrameworkCore.SqlServer </li>
<li> Add Entitis To Context </li>
<li> Add ConnectionString to  appsetting.js </li>
<li> Add DbContext to services in Program.cs </li>
<li>Add Nuget Microsoft.EntityFrameworkCore.Tools to Enable Migrations</li>
<li> Add Migration to Create Database and Tables ==>Add-Migration</li>
<li>update-database ==> TO Create Database And Talbes</li>
</ul>


<h2>  Data Annotation</h2>
<ul>
<li>[Table ("نام جدول جهت درج در جدول")] </li>
<li>[Table ("نام جدول جهت درج در جدول"),Schema="نام Schema"] </li>
<li> for Column==>[Requeired(ErrorMessage="مقدار اعتبار سنجی")] </li>

</ul>
<h2>  Add Index For Table</h2>
<ul>
<li>    [Index(nameof(Name),nameof(Id),IsUnique =true,Name ="Multiple_Index")]
</li>

</ul>


<h2>  Add Foregin Key</h2>
<ul>
<li>      public long? AuthorId { get; set; }
        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; }

</li>
<li>        [InverseProperty(nameof(Author))]
        public List<Course> Courses { get; set; }
 </li>
</ul>

<h2>  OnModelCreating VS OnConfiguration</h2>
<ul>
<li>هنگام فراخونی چندین باره OnModelCreating از همان آبجکت قدیمی استفاده می شود یا به عبارتی نوعی cache  است</li>
<li>OnConfiguration در هر فراخونی یک آبجکت جدید ایجاد می شود </li>
<li> تمامی تعاریف ویژگی برای هر ستون در  OnModelCreating تعریف می شود</li>
</ul>
<h2> Fluent API</h2>
<table>
<tr>
<td> عنوان</td>
<td>کد </td>
</tr>
<tr>
<td>Multikey </td>
<td> modelBuilder.Entity<OBJ>().HasAlternateKey(x=>new{x.id,x.AuthorId});
</td>
</tr>
<tr>
<td> IsRequired</td>
<td>            modelBuilder.Entity<User>().Property(x=>x.Mobile).IsRequired();
 </td>
</tr>
<tr>
<td> DefaultValue</td>
<td>            modelBuilder.Entity<User>().Property(x=>x.Mobile).HasDefaultValueSql("GETDATE()");
 </td>
</tr>
<tr>
<td>Index </td>
<td>             modelBuilder.Entity<User>().HasIndex(x => x.Id);
</td>
</tr>
<tr>
<td> Concurancy</td>
<td>  modelBuilder.Entity<User>().Property(x => x.Mobile).IsRowVersion();</td>
</tr>
</table>
<h2> 1 to Many </h2>
            modelBuilder.Entity<Author>().HasMany(x=>x.Courses).WithOne(x=>x.Author).HasForeignKey(x=>x.AuthorId);
<h2> 1 to 1 </h2>
هر دانش آموز یک آدرس دارد
            modelBuilder.Entity<Student>().HasOne(x => x.StudentAddress)
                .WithOne(x=>x.Student).HasForeignKey<StudentAddress>(x=>x.StudentId);
<b>تعیین جدول اصلی
HasPrincipalKey </b>

            modelBuilder.Entity<Student>().HasOne(x => x.StudentAddress)
                .WithOne(x=>x.Student).HasForeignKey<StudentAddress>(x=>x.StudentId).HasPrincipalKey<Student>(x=>x.Id);

<hr/>



<h2>Controller </h2>
has Output listed below:
<ul>
<li> ContentResult <p> Return Html content</p> </li>
<li>JsonResult <p> Return Json content</p> </li>
<li> FileResult <p>A.Virtual </p> <p>B.Physical </p><p>C.File Content Result </p> </li>
<li>Status Code Result </li>
<li>Redirect Result</li>
</ul>
<p>
<b>VirtualFileResult:</b>
برای ارسال فایل‌هایی که در مسیر مجازی (مثل مسیرهای نسبی در پروژه) قرار دارند، استفاده می‌شود.
این نوع نتایج با استفاده از یک مسیر مجازی به فایل اشاره می‌کند.
~/Content/image.jpg
</P>
<hr/>
<b>PhysicalFileResult:</b>
برای ارسال فایل‌هایی که در سیستم فایل واقعی سرور قرار دارند، استفاده می‌شود.
این نوع نتایج با استفاده از یک مسیر فیزیکی به فایل اشاره می‌کند.
/var/www/html/Content/images/photo.p
<hr/>
<b>FileContentResult:</b>
<p>
برای ارسال محتویات یک فایل به صورت بایت‌ها استفاده می‌شود.
این نوع نتیجه معمولاً برای فایل‌هایی که محتوا در حافظه (مثلاً بایت‌های یک تصویر یا فایل متنی) ذخیره شده‌اند، استفاده می‌شود.
یعنی با آرایه ای از بایت کار میکند
ازکتابخانه system.io.file.readallfile  استفاده میکنیم
<b>byte[] byte=System.IO.File.ReadAllBytes(@"آدرس فیزیکی")
return new FileContentResult(byte,"جنس فایل") --> application/pdf</b>
</p>
</div>
<h3> Model Validation </h3>

<p>Add Error to model validator </p>
ModelState.AddModelError((objectTitle),"Error Message");

<p>Check If Model Is valid Or Not </p>
if(!ModelState.IsValid)
{
var erros=string.Join("\n",ModelState.Values.SelectMany(v=>v.Erros).Select(err=>err.ErrorMessage));
}
