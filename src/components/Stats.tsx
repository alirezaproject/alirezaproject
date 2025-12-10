"use client"

import CountUp from 'react-countup';

const stats = [
    {
        title: "سال تجربه‌ی کاری",
        value: 5,
        suffix: "+",
    },
    {
        title: "پروژه‌ی موفق",
        value: 20,
        suffix: "+",
    },
    {
        title: "رضایت کارفرما",
        value: 100,
        suffix: "%",
    },
    {
        title: "ساعت کدنویسی",
        value: 10000,
        suffix: "+ ساعت",
    }


]

const Stats = () => {
    return (
        <section className='pt-4 pb-12 lg:pt-0 lg:pb-0'>
            <div className="cotainer mx-auto">
                <div className="grid grid-cols-2 lg:grid-cols-4 gap-6 max-w-[80vw] mx-auto lg:max-w-7xl">
                    {stats.map((stat, index) => (
                        <div className="flex-1 flex gap-4 items-center justify-start lg:justify-start
                " key={index}>

                            <CountUp className='text-2xl lg:text-4xl font-bold text-start'
                                duration={5} delay={2} key={index} end={stat.value} suffix={stat.suffix} />
                            <p
                                className={`${stat.title.length < 15 ? "max-w-[100px]" : "max-w-[150px]"}
                            leading-snug text-white/80
                            `}>{stat.title}</p>
                        </div>
                    ))}
                </div>
            </div>
        </section>
    )
}

export default Stats