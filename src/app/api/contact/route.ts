import { Resend } from "resend";
import { NextResponse } from "next/server";


const resend = new Resend(process.env.RESEND_API_KEY);

export async function POST(request: Request) {
    try {
        const { name, lastname, email, phone, message, website } = await request.json();

        if (website) {
            return NextResponse.json({ success: false, message: "Bot detected" }, { status: 400 });
        }
        else {
            await resend.emails.send({
                from: "Website <onboarding@resend.dev>",
                to: "alirezashokouhian79@gmail.com",
                subject: "پیام از طرف سایت شخصی علی رضا شکوهیان",
                html: `
        <h3>New Message From Website</h3>
        <p><b>Name:</b> ${name} ${lastname}</p>
        <p><b>Email:</b> ${email}</p>
        <p><b>Phone:</b> ${phone}</p>
        <p><b>Message:</b> ${message}</p>
      `
            });

            return NextResponse.json({ success: true });
        }


    } catch (err) {
        console.error(err);
        return NextResponse.json({ success: false }, { status: 500 });
    }
}
