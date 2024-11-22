import whisper from 'whisper.js';

class RealtimeWhisperRecognition {
  constructor(options = {}) {
    this.model = null;
    this.options = {
      modelType: 'tiny', // 'tiny', 'base', or other model sizes
      language: 'en',    // Language of the audio
      chunkDuration: 1000, // Duration of each audio chunk in milliseconds
      overlapDuration: 200, // Overlap between consecutive chunks in milliseconds
      ...options
    };
  }

  async initializeModel() {
    try {
      console.log("Loading Whisper model...");
      // Load the WebAssembly version of Whisper
      this.model = await whisper.load({
        model: this.options.modelType,
        webAssembly: true
      });
      console.log("Whisper model loaded successfully.");
    } catch (error) {
      console.error('Failed to load Whisper model:', error);
    }
  }

  async processAudioChunk(audioChunk) {
    if (!this.model) {
      console.error("Model not initialized. Call initializeModel() first.");
      return null;
    }

    try {
      // Process the audio chunk
      const result = await this.model.transcribe(audioChunk, {
        language: this.options.language,
        beam_size: 1, // Optimize for speed
        best_of: 1,   // Reduce hypotheses
        patience: 0   // Minimize additional processing
      });
      return result.text;
    } catch (error) {
      console.error('Speech recognition error:', error);
      return null;
    }
  }

  async startStreamingRecognition(audioStream, onPartialResult) {
    if (!this.model) {
      await this.initializeModel();
    }

    // Split the audio stream into chunks and process each one
    const audioChunks = this.splitAudioStream(audioStream);
    for (const chunk of audioChunks) {
      const partialText = await this.processAudioChunk(chunk);
      if (partialText && typeof onPartialResult === 'function') {
        onPartialResult(partialText);
      }
    }
  }

  splitAudioStream(audioStream) {
    // Simulated splitting of audio stream into smaller chunks
    // In a real implementation, you'd capture audio stream data and slice it into chunks
    const chunkDuration = this.options.chunkDuration;
    const overlapDuration = this.options.overlapDuration;

    const audioChunks = [];
    let startTime = 0;

    while (startTime < audioStream.duration) {
      const endTime = Math.min(startTime + chunkDuration, audioStream.duration);
      const chunk = audioStream.slice(startTime, endTime + overlapDuration);
      audioChunks.push(chunk);
      startTime += chunkDuration - overlapDuration;
    }

    return audioChunks;
  }
}

// Example usage
async function setupSpeechRecognition() {
  const whisperRecognition = new RealtimeWhisperRecognition({
    modelType: 'tiny', // Use 'base' for better accuracy
    language: 'en',
    chunkDuration: 1000, // Process 1-second chunks
    overlapDuration: 200 // 200ms overlap for context
  });

  // Initialize the model
  await whisperRecognition.initializeModel();

  // Start capturing audio
  try {
    const audioStream = await navigator.mediaDevices.getUserMedia({ audio: true });
    console.log("Audio stream captured.");

    whisperRecognition.startStreamingRecognition(
      audioStream,
      (partialText) => {
        console.log('Partial text:', partialText);
        // Here you can update the UI or perform additional processing
      }
    );
  } catch (error) {
    console.error('Failed to capture audio:', error);
  }
}

setupSpeechRecognition();

