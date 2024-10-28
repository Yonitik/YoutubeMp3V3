import sys
import os
import subprocess
from pytubefix import YouTube
import os
from pathlib import Path
def download_video(url, file_type):
    path_to_download = str(os.path.join(Path.home(), 'Downloads'))
    try:
        yt = YouTube(url)

        if file_type == 'mp3':
            audio_stream = yt.streams.filter(only_audio=True).first()
            output_file = audio_stream.download(path_to_download)

            ffmpeg_path = os.path.join(os.path.dirname(__file__), "ffmpeg", "ffmpeg.exe")

            mp3_file = output_file.rsplit('.', 1)[0] + ".mp3"
            ffmpeg_command = f'"{ffmpeg_path}" -i "{output_file}" -vn -ab 192k -ar 44100 -y "{mp3_file}"'
            subprocess.run(ffmpeg_command, shell=True, check=True)
            os.remove(output_file)
            print(f"MP3 Indirildi: {mp3_file}")

        elif file_type == 'mp4':
            video_stream = yt.streams.get_highest_resolution()
            output_file = video_stream.download(path_to_download)
            print(f"MP+ Indirildi: {output_file}")

    except Exception as e:
        print(f"HATA: {e}")

if __name__ == '__main__':
    url = sys.argv[1]
    file_type = sys.argv[2]
    download_video(url, file_type)