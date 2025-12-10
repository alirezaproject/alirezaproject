import Photo from "@/components/Photo";
import Socials from "@/components/Socials";
import Stats from "@/components/Stats";
import { Button } from "@/components/ui/button";
import { FiDownload } from "react-icons/fi";


export default function Home() {
  return (
    <main className="h-full">
      <div className="container mx-auto h-full">
        <div className="flex flex-col lg:flex-row  items-center justify-between
        lg:pt-8 lg:pb-24">
          {/* text */}
          <div className="text-center lg:text-right flex flex-col items-center  ">
            <h1 className="text-h1 text-accent mb-4">علی رضا شکوهیان</h1>
            <span className="text-lg ">برنامه نویس فول استک</span>
            <p className="max-w-[500px] text-center my-9 mx-8 text-balance text-white/80 leading-10">
              من برنامه‌نویس فول‌استک هستم با ۵ سال تجربه‌ی حرفه‌ای در توسعه‌ی نرم‌افزارهای وب و موبایل با استفاده از Flutter، Next.js و NET.

              تخصص من طراحی و پیاده‌سازی سامانه‌های مدرن، سریع و مقیاس‌پذیر است؛ با تمرکز بر کیفیت کد، بهینه‌سازی عملکرد و ایجاد تجربه‌ی کاربری روان و پایدار برای کسب‌وکارها و کاربران نهایی.</p>

            {/* btn and socials */}
            <div className="flex flex-col lg:flex-row items-center gap-8">
              <Button variant="outline" size="lg" >
                <a href="/resume.pdf" className="flex items-center gap-2">
                  <span>دانلود رزومه</span>
                  <FiDownload className="text-xl" />
                </a>
              </Button>
              <div className="mb-8 lg:mb-0">
                <Socials containerStyles="flex gap-6" iconStyles="w-9 h-9 border border-accent rounded-full flex justify-center items-center text-base
                hover:bg-accent hover:text-primary text-accent hover:transition-all duration-500" />
              </div>
            </div>
          </div>
          {/* photo */}

          <div className="mb-8 lg:mb-0">
            <Photo />
          </div>
        </div>
      </div>
      <Stats />
    </main>
  );
}
