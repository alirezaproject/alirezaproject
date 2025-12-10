"use client"
import Link from 'next/link';
import { usePathname } from 'next/navigation';
import path from 'path';
import React from 'react'

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

export const Nav = () => {
    const pathname = usePathname();

    return (
        <nav className='flex gap-8'>
            {
                navLinks.map((nav, key) =>
                (<Link key={key} href={nav.path}
                    className={`${nav.path === pathname && "text-accent border-b-2"}
                        font-medium hover:text-accent transition-all
                        `}>{nav.name}</Link>))
            }
        </nav>
    )
}
