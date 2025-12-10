"use client"

import { FaHtml5, FaCss3, FaJs, FaReact, } from "react-icons/fa"
import { TbBrandCSharp } from "react-icons/tb";


import { motion } from "framer-motion"


import { SiTailwindcss, SiNextdotjs, SiAdobepremierepro, SiAdobeaftereffects, SiPostgresql, SiDotnet, SiFlutter, SiGit, SiGithub, } from "react-icons/si"
import { Tabs, TabsContent, TabsList, TabsTrigger } from "@/components/ui/tabs"
import { ScrollArea } from "@/components/ui/scroll-area"
import { Tooltip, TooltipContent, TooltipProvider, TooltipTrigger } from "@/components/ui/tooltip"




const about = {
    title: "درباره من",
    description: "من به‌عنوان یک ارائه‌دهنده خدمات حرفه‌ای در حوزه طراحی و توسعه سامانه‌های دیجیتال فعالیت می‌کنم و هدفم ایجاد راه‌حل‌هایی دقیق، قابل اعتماد و متناسب با نیاز هر کسب‌وکار است. رویکرد من بر پایه نظم، مسئولیت‌پذیری و ارائه خروجی باکیفیت شکل گرفته و تلاش می‌کنم در هر همکاری تجربه‌ای شفاف، مؤثر و قابل اتکا ارائه دهم.",
    info: [
        { name: "نام و نام خانوادگی", value: "علیرضا شکوهیان" },
        { name: "شماره تماس", value: "+98 917 263 8641" },
        { name: "ایمیل", value: "shekoohianproject@gmail.com" },
        { name: "تجربه کاری", value: "سال +5" },
    ]
}

const experience = {
    icon: '/assets/resume/badge.svg',
    title: "تجربه کاری",
    description: "تجربه من بر پایه فعالیت در حوزه‌های برنامه‌نویسی، تحلیل بازارهای مالی و تولید محتوای ویدیویی شکل گرفته است. در مسیر کاری خود روی ارائه خروجی دقیق، پایدار و قابل اتکا تمرکز داشته‌ام و تلاش کرده‌ام بین مهارت‌های فنی، تحلیل‌گری و خلاقیت تعادل ایجاد کنم. هدفم همیشه یادگیری مستمر و ارائه کاری حرفه‌ای بوده است.",
    items: [
        {
            company: "تیپ 33 المهدی (ع)",
            position: "توسعه دهنده فول استک",
            duration: " شهریور 1402 - حال حاضر",
        },
        {
            company: "شرکت مراقب طب رستا",
            position: "توسعه دهنده بک اند",
            duration: " فروردین ۱۴۰۰ - شهریور 1402",
        },
        {
            company: "فریلنسر",
            position: "توسعه دهنده فرانت اند",
            duration: "شهریور 1399 - فروردین 1400",
        },
        {
            company: "پشتیبان دوره آموزشی",
            position: "توسعه دهنده بک اند",
            duration: "دی 1398 - شهریور 1399",
        }
    ]
}

const education = {
    icon: '/assets/resume/cap.svg',
    title: "تحصیلات",
    description: "تحصیلات من در مسیری شکل گرفته که بیشتر بر یادگیری عملی و مهارت‌محور تمرکز داشته است. در کنار دوره‌های تخصصی برنامه‌نویسی، تحلیل بازارهای مالی و تولید محتوا، همیشه تلاش کرده‌ام دانشم را با تجربه واقعی ترکیب کنم و آن را در پروژه‌ها و فعالیت‌های روزمره به‌کار بگیرم.",
    items: [

        {
            institution: "دانشگاه پیام نور",
            degree: "کارشناسی مهندسی کامپیوتر",
            duration: "1404 - 1398",
        }
    ]
}

const skills = {
    title: "مهارت‌ها",
    description: "مهارت‌های من بر پایه تجربه عملی در پروژه‌های واقعی و دوره‌های تخصصی شکل گرفته‌اند. در مسیر کاری خود تلاش کرده‌ام بین یادگیری مداوم، طراحی تمیز و ارائه خروجی پایدار تعادل ایجاد کنم. تمرکز اصلی من روی توسعه رابط کاربری، پیاده‌سازی بخش سرور، کار با ابزارهای به‌روز و ساخت سامانه‌های کاربردی است؛ در کنار آن نیز بهبود مهارت‌های تحلیل‌گری و حل مسئله را همیشه در اولویت قرار داده‌ام.",
    skillList: [
        { name: "HTML5", icon: <FaHtml5 /> },
        { name: "CSS3", icon: <FaCss3 /> },
        { name: "JavaScript", icon: <FaJs /> },
        { name: "React", icon: <FaReact /> },
        { name: "Tailwind CSS", icon: <SiTailwindcss /> },
        { name: "Next.js", icon: <SiNextdotjs /> },
        { name: "PostgreSQL", icon: <SiPostgresql /> },
        { name: "Net.", icon: <SiDotnet /> },
        { name: "#C", icon: <TbBrandCSharp /> },
        { name: "Flutter", icon: <SiFlutter /> },
        { name: "Github", icon: <SiGithub /> },
        { name: "Git", icon: <SiGit /> },
        { name: "Premiere Pro", icon: <SiAdobepremierepro /> },
        { name: "After Effect", icon: <SiAdobeaftereffects /> },


    ]
}

const ResumePage = () => {
    return (
        <motion.div initial={{ opacity: 0 }} animate={{ opacity: 1, transition: { duration: 0.4, delay: 2, ease: "easeIn" } }} className="min-h-[80vh] flex items-center justify-center py-12 lg:py-0"
        >
            <div className="container mx-auto">
                <Tabs defaultValue="about" className="flex flex-col  lg:flex-row gap-[60px]">
                    <TabsList className="flex flex-col w-full max-w-[380px] mx-auto lg:mx-0 
                    gap-6">
                        <TabsTrigger value="about">
                            درباره من
                        </TabsTrigger>
                        <TabsTrigger value="experience">تجربه کاری</TabsTrigger>
                        <TabsTrigger value="education">تحصیلات</TabsTrigger>
                        <TabsTrigger value="skills">مهارت‌ها</TabsTrigger>

                    </TabsList>

                    {/* content */}

                    <div className="min-h-[70vh] w-full ">
                        {/* about */}
                        <TabsContent value="about" className="w-full text-center lg:text-right ">
                            <div className="flex flex-col gap-10 items-center lg:items-end ">
                                <h3 className="text-4xl font-bold">{about.title}</h3>
                                <p className="max-w-xl  lg:max-w-3xl text-white/60 mx-4 lg:mx-0 text-right  ">
                                    {about.description}
                                </p>
                                <ul className="grid grid-cols-1  md:grid-cols-1 xl:grid-cols-2 gap-y-6 max-w-xl
                                 lg:mx-0 lg:gap-x-40 lg:max-w-none text-nowrap w-full px-4 lg:px-0">
                                    {about.info.map((item, index) => (
                                        <li key={index} className="flex items-center justify-between  ">
                                            <span className="font-bold">{item.value}</span>
                                            <span className="text-white/60 ">{item.name}</span>
                                        </li>))}
                                </ul>
                            </div>
                        </TabsContent>


                        {/* experience */}
                        <TabsContent value="experience" className="w-full text-center lg:text-right ">
                            <div className="flex flex-col gap-8 items-center lg:items-end ">

                                <h3 className="text-4xl font-bold">{experience.title}</h3>
                                <p className="max-w-xl text-white/60
                                    mx-4
                                  lg:mx-0 text-right ">{experience.description}</p>
                                <ScrollArea className="h-[400px] px-4">
                                    <ul className="grid grid-cols-1 lg:grid-cols-2 gap-8">
                                        {experience.items.map((item, index) => (
                                            <li key={index} className="bg-gray-800/20
                                            h-48 py-6 px-10 rounded-xl flex flex-col items-center justify-center
                                            lg:items-end gap-1">
                                                <span className="text-accent">{item.duration}</span>
                                                <h3 className="text-xl max-w-xs min-h-16
                                                text-center lg:text-right">{item.position}</h3>
                                                <div className="flex items-center gap-3">
                                                    <p className="text-white/60">{item.company}</p>
                                                    {/* dot */}
                                                    <span className="w-2 h-2 rounded-full bg-accent"></span>
                                                </div>
                                            </li>))}
                                    </ul>
                                </ScrollArea>
                            </div>
                        </TabsContent>

                        {/* education */}
                        <TabsContent value="education" className="w-full text-center lg:text-right ">
                            <div className="flex flex-col gap-8 items-center lg:items-end ">
                                <h3 className="text-4xl font-bold">{education.title}</h3>
                                <p className="max-w-[600px] text-white/60
                                 mx-4 lg:mx-0 text-right">{education.description}</p>
                                <ScrollArea className="h-[400px] px-4">
                                    <ul className="grid grid-cols-1 lg:grid-cols-2 gap-8">
                                        {education.items.map((item, index) => (
                                            <li key={index} className="bg-gray-800/20
                                            h-48 py-6 px-10 rounded-xl flex flex-col items-center justify-center
                                            lg:items-end gap-1">
                                                <span className="text-accent">{item.duration}</span>
                                                <h3 className="text-xl max-w-xs min-h-16
                                                text-center lg:text-right">{item.degree}</h3>
                                                <div className="flex items-center gap-3">
                                                    <p className="text-white/60">{item.institution}</p>
                                                    {/* dot */}
                                                    <span className="w-2 h-2 rounded-full bg-accent"></span>
                                                </div>
                                            </li>))}
                                    </ul>
                                </ScrollArea>
                            </div>
                        </TabsContent>

                        {/* skills */}
                        <TabsContent value="skills" className="w-full text-center lg:text-right ">
                            <div className="flex flex-col gap-8 ">

                                <div className="flex flex-col gap-4 text-center lg:text-right items-center lg:items-end ">
                                    <h3 className="text-4xl font-bold ">
                                        {skills.title}
                                    </h3>
                                    <p className="max-w-xl text-white/60 mx-4 lg:mx-0 text-right">
                                        {skills.description}
                                    </p>
                                </div>
                                <ul className="grid grid-cols-2 md:grid-cols-3
                                 lg:grid-cols-4 lg:gap-8 gap-4">
                                    {skills.skillList.map((skill, index) => (
                                        <li key={index} >
                                            <TooltipProvider delayDuration={0} >
                                                <Tooltip>
                                                    <TooltipTrigger className="w-full h-36 bg-gray-800/20 rounded-xl
                                                    flex items-center justify-center group cursor-pointer
                                                    ">
                                                        <div className="text-6xl group-hover:text-accent 
                                                        items-center justify-center flex flex-col
                                                        transition-all duration-300 space-y-2">
                                                            {skill.icon}
                                                            <div className="lg:hidden text-sm font-bold">
                                                                {skill.name}
                                                            </div>
                                                        </div>

                                                    </TooltipTrigger>
                                                    <TooltipContent className="capitalize">
                                                        <p>{skill.name}</p>
                                                    </TooltipContent>
                                                </Tooltip>
                                            </TooltipProvider>
                                        </li>))}
                                </ul>
                            </div>
                        </TabsContent>



                    </div>
                </Tabs>
            </div>
        </motion.div>
    )
}

export default ResumePage