"use client"

import { PiCaretLeftBold, PiCaretRightBold } from "react-icons/pi";
import { useSwiper } from "swiper/react";

const WorkSliderBtns = (
    { containerStyles, btnStyles, iconStyles }:
        { containerStyles: string, btnStyles: string, iconStyles: string }) => {

    const swiper = useSwiper();

    return (
        <div className={containerStyles}>
            <button className={btnStyles} onClick={() => swiper.slidePrev()}>
                <PiCaretRightBold className={iconStyles} />

            </button>

            <button className={btnStyles} onClick={() => swiper.slideNext()}>
                <PiCaretLeftBold className={iconStyles} />
            </button>

        </div>
    )
}

export default WorkSliderBtns