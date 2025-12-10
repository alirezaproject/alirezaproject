"use client"
import { AnimatePresence, motion } from "framer-motion"
import { usePathname } from "next/navigation"



const PageTransition = ({ children }: { children: React.ReactNode }) => {

    const pathname = usePathname();

    return (
        <AnimatePresence>

            <div key={pathname}>
                <motion.div initial={{ opacity: 1 }}
                    className="h-screen w-screen bg-primary fixed top-0 pointer-events-none"
                    animate={{ opacity: 0, transition: { delay: 1, duration: 0.4, ease: "easeInOut" } }}>

                </motion.div>
                {children}
            </div>

        </AnimatePresence>
    )
}

export default PageTransition