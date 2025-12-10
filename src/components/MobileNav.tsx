"use client"

import { usePathname } from "next/navigation";
import { Sheet, SheetContent, SheetTrigger } from "./ui/sheet";
import { CiMenuFries } from "react-icons/ci";
import { DialogTitle } from "@radix-ui/react-dialog";
import Image from "next/image";
import Link from "next/link";


const navLinks = [
    {
        name: "خانه",
        path: "/",
    },
    {
        name: "خدمات",
        path: "/services"
    },
    {
        name: "رزومه",
        path: "/resume",
    },
    {
        name: "نمونه کار",
        path: "/projects",
    },
    {
        name: "ارتباط با من",
        path: "/contact",
    },
];


const MobileNav = () => {
    const pathname = usePathname();
    return (
        <Sheet>
            <SheetTrigger className="flex justify-center items-center">
                <CiMenuFries className="text-[32px] text-accent" />
            </SheetTrigger>
            <DialogTitle>


            </DialogTitle>
            <SheetContent className="flex flex-col items-center justify-center ">
                {/* Logo */}
                <div className="mb-32 -mt-20 text-center text-2xl ">
                    <Link href="/">
                        <Image src="/assets/logo.png" className="" alt='logo' width={150} height={150} />
                    </Link>
                </div>

                {/* nav */}
                {navLinks.map((link, index) => (
                    <Link
                        key={index}
                        href={link.path}
                        className={`mb-8 text-xl hover:text-accent transition-all 
                            ${pathname === link.path ? "text-accent border-b-2 font-bold" : "text-white"}`} >
                        {link.name}
                    </Link>))}

            </SheetContent>
        </Sheet>
    )
}

export default MobileNav