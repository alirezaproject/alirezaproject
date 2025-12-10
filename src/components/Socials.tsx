
import Link from "next/link";
import { FaGithub, FaLinkedinIn, FaTelegram, FaWhatsapp } from "react-icons/fa";

const socialIcons = [
    { icon: <FaGithub />, href: "https://github.com/alirezaproject" },
    { icon: <FaLinkedinIn />, href: "https://www.linkedin.com/in/alirezashokouhian/" },
    { icon: <FaTelegram />, href: "https://t.me/alirezaproject" },
    { icon: <FaWhatsapp />, href: "https://wa.me/+989172638641" },
];

const Socials = ({ containerStyles, iconStyles }: { containerStyles?: string, iconStyles?: string }) => {
    return (
        <div className={containerStyles}>
            {socialIcons.map((social, index) => {
                return <Link key={index} href={social.href} target="_blank" className={iconStyles}>{social.icon}</Link>
            })}
        </div >
    )

}

export default Socials