"use client";

import Image from "next/image";
import { motion } from "framer-motion";

const Photo = () => {
  return (
    <div className="w-full h-full relative">

      {/* image */}
      <motion.div initial={{ opacity: 0 }}
        animate={{ opacity: 1 }}
        transition={{ delay: 2, duration: 0.5, ease: "easeIn" }}>
        <motion.div
          initial={{ opacity: 0 }}
          animate={{ opacity: 1 }}
          transition={{ delay: 2.4, duration: 0.5, ease: "easeInOut" }}

          className="w-[280px] h-[280px] lg:w-[480px] lg:h-[480px]
          absolute mix-blend-lighten rounded-full overflow-hidden top-0 left-0 right-0 -bottom-5
          m-auto ">
          <Image src="/assets/profile.png"
            className="object-cover"
            priority fill alt="photo"  />
        </motion.div>
      </motion.div>
      {/* circle */}
      <motion.svg
        initial={{ opacity: 0 }}
        animate={{ opacity: 1 }}
        transition={{ delay: 2.4, duration: 0.5, ease: "easeInOut" }}
        className="w-[300px] lg:w-[500px] h-[300px] lg:h-[500px]" fill="transparent"
        viewBox="0 0 506 506" xmlns="http://www.w3.org/2000/svg">
        <motion.circle cx="253" cy="253" r="250" stroke="#00ff99"
          strokeWidth="6" strokeLinecap="round" strokeLinejoin="round"
          initial={{ strokeDasharray: "24 10 0 0" }}
          animate={{
            strokeDasharray: ["15 120 25 25", "16 25 92 72", "4 250 22 22"],
            rotate: [120, 360]
          }}
          transition={{ duration: 20, repeat: Infinity, repeatType: "reverse" }}
        >
        </motion.circle>
      </motion.svg>
    </div>
  )
}

export default Photo