"use client";

import { motion } from "framer-motion"
import { Swiper, SwiperSlide } from "swiper/react"
import "swiper/css";
import "swiper/css/navigation";
import "swiper/css/pagination";

import { useState } from "react";
import Image from "next/image";
import WorkSliderBtns from "@/components/WorkSliderBtns";
import Link from "next/link";
import { Tooltip, TooltipContent, TooltipProvider, TooltipTrigger } from "@/components/ui/tooltip";
import { BsArrowUpRight, BsGithub } from "react-icons/bs";


const projects = [
    {
        num: '01',
        category: 'طراحی سایت',
        title: 'طراحی سایت معرفی AI',
        description: 'یک ابزار هوشمند برای تولید UI/UX با استفاده از هوش مصنوعی. این پروژه طراحی شده تا فرآیند ایده‌پردازی، طراحی رابط کاربری و تولید کامپوننت‌های گرافیکی را ساده، سریع و کاملاً تعاملی کند. نسخه آنلاین پروژه از طریق لینک زیر دردسترس است:',
        stack: ['React', 'Next.js', 'Tailwind CSS'],
        image: '/assets/work/code-flow.png',
        live: "https://code-flow-ai-ui-ux.vercel.app/",
        github: "https://github.com/alirezaproject/code-flow-ai-ui-ux"
    },

];

const ProjectPage = () => {

    const [project, setProject] = useState(projects[0]);

    return (
        <motion.section initial={{ opacity: 0 }}
            animate={{ opacity: 1, transition: { ease: "easeIn", delay: 1.0, duration: 0.4 } }}
            className="min-h-[80vh] flex flex-col justify-center py-12 lg:px-0">

            <div className="container mx-auto px-4">

                <div className="flex flex-col lg:flex-row lg:gap-8">
                    <div className="w-full lg:w-[50%] lg:h-[460px] flex flex-col
                    lg:justify-between order-2 lg:order-none">
                        <div className="flex flex-col gap-7 h-1/2">
                            {/* outline num */}
                            <div className="text-8xl leading-none font-extrabold text-transparent
                        text-outline">
                                {project.num}
                            </div>

                            {/* project category */}
                            <h2 className="text-4xl font-bold leading-none text-white
                        group-hover:text-accent transition-all duration-500">
                                پروژه {project.category}
                            </h2>
                            {/* description */}
                            <p className="text-white/60">
                                {project.description}
                            </p>
                            {/* stack */}
                            <ul className="flex gap-4 ">
                                {project.stack.map((tech, index) => (
                                    <li key={index} className="text-xl text-accent">
                                        {tech}
                                        {index !== project.stack.length - 1 && ','}
                                    </li>
                                ))}
                            </ul>
                            {/* border */}
                            <div className="border border-white/20"></div>

                            {/* buttons */}

                            <div className="flex gap-4 items-center">
                                {/* live project button */}
                                <Link href={project.live} target="_blank">
                                    <TooltipProvider delayDuration={100}>
                                        <Tooltip>
                                            <TooltipTrigger className="w-16 h-16 rounded-full bg-white/5 
                                        flex items-center justify-center group cursor-pointer">
                                                <BsArrowUpRight className="text-white text-3xl group-hover:text-accent" />
                                            </TooltipTrigger>
                                            <TooltipContent>
                                                <p>مشاهده پروژه</p>
                                            </TooltipContent>
                                        </Tooltip>
                                    </TooltipProvider>
                                </Link>

                                {/* github project button */}
                                <Link href={project.github} target="_blank">
                                    <TooltipProvider delayDuration={100}>
                                        <Tooltip>
                                            <TooltipTrigger className="w-16 h-16 rounded-full bg-white/5 
                                        flex items-center justify-center group cursor-pointer">
                                                <BsGithub className="text-white text-3xl group-hover:text-accent" />
                                            </TooltipTrigger>
                                            <TooltipContent>
                                                <p>مشاهده کد</p>
                                            </TooltipContent>
                                        </Tooltip>
                                    </TooltipProvider>
                                </Link>
                            </div>

                        </div>
                    </div>

                    <div className="w-full lg:w-[50%] " >
                        <Swiper

                            direction="horizontal"
                            spaceBetween={30}
                            slidesPerView={1}
                            className="lg:h-[520px] mb-12"
                            onSlideChange={(swiper) => setProject(projects[swiper.activeIndex])}
                        >
                            {projects.map((project, i) => (
                                <SwiperSlide key={i} className="w-full">
                                    <div className="h-[460px] relative group flex justify-center items-center bg-pink-50/20">

                                        <div className="absolute top-0 bottom-0 w-full h-full bg-black/10 z-10"></div>

                                        <div className="relative w-full h-full">
                                            <Image
                                                src={project.image}
                                                fill
                                                className="object-cover"
                                                alt=""
                                            />
                                        </div>
                                    </div>
                                </SwiperSlide>
                            ))}

                            <WorkSliderBtns
                                iconStyles=""
                                containerStyles="flex gap-2 absolute right-0 bottom-[calc(50%_-_22px)]  lg:bottom-0 z-20 w-full justify-between 
                                lg:w-max lg:justify-none"
                                btnStyles="bg-accent hover:bg-accent-hover 
                                text-primary text-[22px]
      w-[44px] h-[44px] lg:w-[60px] flex items-center justify-center transition-all"
                            />
                        </Swiper>
                    </div>

                </div>
            </div>
        </motion.section>
    )
}

export default ProjectPage