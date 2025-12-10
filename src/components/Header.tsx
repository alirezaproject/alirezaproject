import Image from 'next/image'
import Link from 'next/link'
import React from 'react'
import { Nav } from './Nav'
import MobileNav from './MobileNav'

export const Header = () => {
    return (
        <header className='py-4 lg:py-8 text-white container mx-auto'>
            <div className=" flex items-center justify-between px-2">

                {/* Mobile Nav */}
                <div className="lg:hidden">
                    <MobileNav />
                </div>

                {/* Desktop Nav */}
                <div className="hidden lg:flex items-center gap-8">
                    <Nav />
                </div>
                {/* Logo */}
                <Link href="/">
                    <Image src="/assets/logo.png" alt='logo' width={100} height={100} />
                </Link>
            </div>
        </header>
    )
}
