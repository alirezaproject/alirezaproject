"use client"

import { FaEnvelope, FaMapMarkedAlt, FaPhoneAlt } from "react-icons/fa"

import { motion } from "framer-motion"
import { Input } from "@/components/ui/input"
import { Textarea } from "@/components/ui/textarea"
import { Button } from "@/components/ui/button"
import toast from "react-hot-toast";
import { useState } from "react"


const info = [
    {
        icon: <FaPhoneAlt />,
        title: "شماره تماس",
        description: "+98 917 263 8641"
    },
    {
        icon: <FaEnvelope />,
        title: "ایمیل",
        description: "shekoohianproject@gmail.com"
    },
    {
        icon: <FaMapMarkedAlt />,
        title: "آدرس",
        description: "شیراز، ایران"
    }
]

const ContactPage = () => {
    const [loading, setLoading] = useState(false);

    async function handleSubmit(e: React.FormEvent<HTMLFormElement>) {
        e.preventDefault();
        setLoading(true);

        const form = new FormData(e.target as HTMLFormElement);

        const res = await fetch("/api/contact", {
            method: "POST",
            body: JSON.stringify({
                name: form.get("name"),
                lastname: form.get("lastname"),
                email: form.get("email"),
                phone: form.get("phone"),
                message: form.get("message"),
                website: form.get("website"),
            }),
        });

        setLoading(false);

        const data = await res.json();

        if (data.success) {
            toast.success("پیام با موفقیت ارسال شد! 🌟");
            (e.target as HTMLFormElement).reset();
        } else {
            toast.error("خطایی رخ داد. دوباره امتحان کن ❌");
        }
    }


    return (
        <motion.section initial={{ opacity: 0 }}
            animate={{ opacity: 1, transition: { duration: 0.5, delay: 2, ease: "easeIn" } }}
            className="py-6">
            <div className="container mx-auto px-4">
                <div className="flex flex-col lg:flex-row gap-8 items-start">
                    {/* Form */}
                    <div className="lg:h-[54%] order-1 lg:order-2">
                        <form className="flex flex-col gap-6 p-10 bg-pink-50/10 rounded-xl" onSubmit={handleSubmit}>
                            <h3 className="text-4xl text-accent">ارتباط با من</h3>
                            <p className="text-white/60 leading-8">
                                اگر برای پروژه‌های وب، موبایل، UI/UX یا توسعه وب‌سرویس به یک متخصص قابل‌اعتماد نیاز دارید، خوشحال می‌شوم با شما گفتگو کنم.

                                من با بیش از ۵ سال تجربه حرفه‌ای در Next.js، .NET ، Flutter و انجام انواع پروژه های موفق، آماده‌ام ایده‌تان را با بهترین کیفیت و در کوتاه‌ترین زمان اجرا کنم.

                                برای شروع همکاری، دریافت مشاوره یا استعلام قیمت، از طریق فرم زیر یا شبکه‌های اجتماعی با من در ارتباط باشید.

                                پاسخگویی: زیر ۲۴ ساعت
                            </p>
                            {/* input */}
                            <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
                                <Input name="name" placeholder="نام" />
                                <Input name="lastname" placeholder="نام خانوادگی" />
                                <Input name="email" placeholder="ایمیل" />
                                <Input name="phone" placeholder="شماره تماس" />
                                <Input
                                    type="text"
                                    name="website"
                                    className=""

                                    autoComplete="off"
                                />
                            </div>
                            {/* textarea */}
                            <Textarea name="message" className="h-[200px]" placeholder="متن پیام خود را بنویسید" />
                            {/* btn */}
                            <Button disabled={loading} type="submit" size="lg" className="max-w-40 flex justify-center items-center" >
                                ارسال پیام
                            </Button>
                        </form>
                    </div>
                    {/* info */}
                    <div className="flex-1 flex items-center lg:justify-start  mb-8 lg:mb-0">
                        <ul className="flex flex-col gap-10">
                            {info.map((item, index) => (
                                <li key={index} className="flex items-center gap-6 ">
                                    <div className="w-14 h-14 lg:w-20 lg:h-20 bg-pink-50/10 text-accent
                                    flex justify-center items-center text-2xl lg:text-3xl rounded-md  ">
                                        <div className="">{item.icon}</div>
                                    </div>
                                    <div className="">
                                        <p>{item.title}</p>
                                        <h3 className="text-left text-white/60" dir="ltr">{item.description}</h3>
                                    </div>
                                </li>
                            ))}
                        </ul>
                    </div>
                </div>
            </div>
        </motion.section >
    )
}

export default ContactPage