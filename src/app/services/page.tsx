"use client"

import { BsArrowDownRight } from "react-icons/bs"
import { motion } from "framer-motion"
import Link from "next/link";

const services = [
    {
        num: "01",
        title: "طراحی و توسعه سایت",
        description:
            "طراحی و پیاده‌سازی وب‌سایت‌های مدرن، ریسپانسیو و بهینه‌شده با تمرکز بر تجربه کاربری و عملکرد بالا.",
    },
    {
        num: "02",
        title: "طراحی و ساخت اپلیکیشن",
        description:
            "توسعه اپلیکیشن‌های موبایل با رابط کاربری حرفه‌ای و معماری استاندارد، مناسب برای ارائه خدمات سریع و قابل‌اعتماد.",
    },
    {
        num: "03",
        title: "ترید و تحلیل بازار",
        description:
            "تحلیل، بهینه‌سازی استراتژی‌ها و بررسی روند بازارهای مالی با رویکرد دقیق، مدیریت ریسک و تصمیم‌گیری هوشمند.",
    },
    {
        num: "04",
        title: "تدوین و ادیت محتوا",
        description:
            "تدوین و ویرایش حرفه‌ای ویدئوها برای ساخت محتوای باکیفیت، خلاقانه و مناسب شبکه‌های مختلف.",
    },
];

const ServicesPage = () => {
    return (
        <section className="min-h-[80vh] flex flex-col justify-center px-4 py-12 lg:py-0">
            <div className="container mx-auto">
                <motion.div
                    className="grid grid-cols-1 md:grid-cols-2 gap-[60px]"
                    initial={{ opacity: 0 }}
                    animate={{
                        opacity: 1,
                        transition: { duration: 0.4, ease: "easeIn", delay: 2.0 }
                    }}
                >
                    {services.map((service, index) =>
                    (
                        <div key={index} className="flex-1 flex-col justify-center space-y-8   group">
                            {/* Top */}
                            <div className="w-full flex justify-between items-center group ">
                                <div className="text-5xl 
                                    font-extrabold transition-all duration-500
                                     group-hover:text-accent
                                    ">
                                    {service.num}
                                </div>
                                <Link href="#" className="w-16 h-16 rounded-full bg-white
                                group-hover:bg-accent transition-all duration-500 flex justify-center items-center group-hover:-rotate-45">
                                    <BsArrowDownRight className="text-primary text-3xl" />
                                </Link>
                            </div>
                            <h2 className="text-2xl font-bold leading-none
                             text-white group-hover:text-accent transition-all duration-500">
                                {service.title}
                            </h2>
                            <p className="text-white/60">{service.description}</p>
                            <div className="border-b border-white/20 w-full"></div>
                        </div>
                    ))}

                </motion.div>
            </div>
        </section>
    )
}

export default ServicesPage